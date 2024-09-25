
CREATE PROCEDURE [dbo].[SP_Marcaciones](@FechaIni DATE, @FechaFin DATE, @Like NVARCHAR(30) ,@CodigoSucursal VARCHAR(3)) AS BEGIN;
WITH DATE_RANGE
 AS
(SELECT
		e.CodigoEmpleado,DATEADD(DAY, [number], @FechaIni) AS Fecha
	FROM (SELECT DISTINCT
			[number]
		FROM master.dbo.spt_values v
		WHERE [name] IS NULL) n,empleado e
	WHERE DATEADD(DAY, [number], @FechaIni) <= @FechaFin)

 SELECT
	 ISNULL(e.CodigoEmpleado, 0) CodigoEmpleado
   ,ISNULL(e.NombreEmpleado, '') NombreEmpleado
   ,ISNULL(e.CodigoSucursal, 0) CodigoSucursal
   ,ISNULL(s.Nombre, '') Sucursal
   ,r.fecha Fecha
   ,Entrada
   ,Salida
   ,CONVERT(DECIMAL(18, 2), DATEDIFF(HOUR, Inicia, Termina)) HorasReglamentarias
   ,isNULL(CONVERT(DECIMAL(18, 2), DATEDIFF(HOUR, Entrada, Salida)),0) HorasMarcadas

   ,CONVERT(DECIMAL(18, 2), ABS(CASE
		WHEN DATEDIFF(HOUR, Inicia, Termina) > isNULL(DATEDIFF(HOUR, Entrada, Salida),0) THEN (DATEDIFF(MINUTE, Inicia, Termina) - isNUll(DATEDIFF(MINUTE, Entrada, Salida),0)) / 60
		ELSE 0
	END)) TiempoEnContra

   ,CONVERT(DECIMAL(18, 2), ABS(CASE
		WHEN DATEDIFF(HOUR, Inicia, Termina) < DATEDIFF(HOUR, Entrada, Salida) THEN (DATEDIFF(MINUTE, Inicia, Termina) - DATEDIFF(MINUTE, Entrada, Salida)) / 60
		ELSE 0
	END)) TiempoAFavor
   ,ISNULL(j.Horas_Justificadas, 0) HorasJustificadas
   ,isNULL(ABS(CASE
		WHEN DATEDIFF(HOUR, Inicia, Termina) <= DATEDIFF(HOUR, Entrada, Salida) THEN DATEDIFF(HOUR, Inicia, Termina)
		ELSE DATEDIFF(MINUTE, Entrada, Salida) / 60
	END),0) + ISNULL(j.Horas_Justificadas, 0) CantidadHorasFinal
	,ISNULL(j.Horas_extras, 0) HorasExtras

 FROM Date_range r
 INNER JOIN Empleado e ON r.CodigoEmpleado = e.CodigoEmpleado and e.CodigoSucursal IN(Select e.CodigoSucursal from Sucursal WHERE CONVERT(varchar,e.CodigoSucursal) LIKE '%' + @CodigoSucursal + '%')
 INNER JOIN Sucursal s ON s.CodigoSucursal = e.CodigoSucursal
 INNER JOIN Horario h  ON h.CodigoHorario = e.CodigoHorario 
 LEFT JOIN (SELECT
		m.CodigoEmpleado
	   ,CONVERT(DATE, m.fecha) FechaMarca
	   ,MIN(m.Entrada) Entrada
	   ,MAX(m.Salida) Salida
	 FROM ( SELECT
			 ROW_NUMBER() OVER (PARTITION BY CONVERT(DATE, fecha), codigoEmpleado ORDER BY fecha ASC) id
		   ,m.codigoEmpleado
		   ,m.IdMarcacion
		   ,m.CodigoSucursal
		   ,m.fecha
		   ,m.fecha Entrada
		   ,NULL Salida
		 FROM Marcacion m Where m.Fecha BETWEEN @FechaIni AND @FechaFin 
		
		UNION ALL SELECT
			ROW_NUMBER() OVER (PARTITION BY CONVERT(DATE, fecha), codigoEmpleado ORDER BY fecha DESC) id
		   ,m.codigoEmpleado
		   ,m.IdMarcacion
		   ,m.CodigoSucursal
		   ,m.fecha
		   ,NULL Entrada
		   ,m.fecha Salida
		FROM Marcacion m Where m.Fecha BETWEEN @FechaIni AND @FechaFin ) m
	WHERE m.id = 1
	GROUP BY m.codigoEmpleado
			,m.CodigoSucursal
			,CONVERT(DATE, m.fecha)
) m  ON CONVERT(DATE, m.FechaMarca) = CONVERT(DATE, r.Fecha) AND r.CodigoEmpleado = m.CodigoEmpleado
 LEFT JOIN (
 SELECT
		j.CodigoEmpleado
	   ,CONVERT(date,j.Fecha)Fecha
	   ,SUM(CASE WHEN tj.IsSalida = 1 THEN j.Horas ELSE 0 END) Horas_Justificadas
	   ,SUM(CASE WHEN tj.IsSalida = 1 THEN 0 ELSE Horas END) Horas_extras
	 FROM [dbo].[Justificacion] j 
	 INNER JOIN TipoJustificacion tj
		ON j.CodigoTipoJustificacion = tj.CodigoTipoJustificacion
	 WHERE j.IsEliminado = 0 
	 AND j.CodigoEstado = 2  and CONVERT(date,j.Fecha) BETWEEN @FechaIni AND @FechaFin
	 GROUP BY j.CodigoEmpleado
			,CONVERT(date,j.Fecha)

) j ON j.CodigoEmpleado = r.CodigoEmpleado AND CONVERT(DATE, j.Fecha) = CONVERT(DATE, r.Fecha)
 ORDER BY r.Fecha;
 END