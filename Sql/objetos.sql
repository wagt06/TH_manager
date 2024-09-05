
CREATE PROCEDURE [dbo].[SP_Marcaciones](@FechaIni DATE, @FechaFin DATE, @Like NVARCHAR(30) ,@CodigoSucursal INT) AS BEGIN;


WITH DATE_RANGE 
    AS
( SELECT 
		DATEADD(DAY, [number], @FechaIni)  AS Fecha
	FROM ( SELECT  DISTINCT
			[number]
		FROM master.dbo.spt_values
		WHERE [name] IS NULL)  n
	WHERE DATEADD(DAY, [number], @FechaIni)  <= @FechaFin) 

SELECT 
	ISNULL(m.CodigoEmpleado, 0)  CodigoEmpleado
   ,ISNULL(m.NombreEmpleado, '')  NombreEmpleado
   ,ISNULL(m.CodigoSucursal, 0)  CodigoSucursal
   ,ISNULL(m.sucursal, '')  Sucursal
   ,r.fecha Fecha
   ,Entrada
   ,Salida
   ,CONVERT(decimal(18,2),DATEDIFF(HOUR,Inicia,Termina))  HorasReglamentarias
   ,CONVERT(decimal(18,2),DATEDIFF(HOUR,Entrada,Salida))  HorasMarcadas
   ,CONVERT(decimal(18,2),ABS(CASE WHEN DATEDIFF(HOUR,Inicia,Termina)  > DATEDIFF(HOUR,Entrada,Salida)  THEN  (DATEDIFF(MINUTE,Inicia,Termina)  - DATEDIFF(MINUTE,Entrada,Salida))/60  ELSE 0 END))  TiempoEnContra
   ,CONVERT(decimal(18,2),ABS(CASE WHEN DATEDIFF(HOUR,Inicia,Termina)  < DATEDIFF(HOUR,Entrada,Salida)  THEN  (DATEDIFF(MINUTE,Inicia,Termina)  - DATEDIFF(MINUTE,Entrada,Salida))/60  ELSE 0 END))  TiempoAFavor
   ,isNULL(j.Horas_Justificadas,0) HorasJustificadas
   ,isNULL(j.Horas_extras,0) Horas_extras
   ,ABS(CASE WHEN DATEDIFF(HOUR,Inicia,Termina)  <= DATEDIFF(HOUR,Entrada,Salida)  THEN  DATEDIFF(HOUR,Inicia,Termina) ELSE DATEDIFF(MINUTE,Entrada,Salida)/60 END) + isNULL(j.Horas_Justificadas,0)  CantidadHorasFinal
 FROM Date_range r
 LEFT JOIN ( SELECT 
		m.CodigoEmpleado
	   ,e.NombreEmpleado
	   ,m.CodigoSucursal
	   ,s.Nombre Sucursal
	   ,e.CodigoHorario
	   ,CONVERT(DATE, m.fecha)  FechaMarca
	   ,MIN(m.Entrada)  Entrada
	   ,MAX(m.Salida)  Salida
	 FROM ( SELECT 
			ROW_NUMBER()  OVER (PARTITION BY CONVERT(DATE, fecha) , codigoEmpleado ORDER BY fecha ASC)  id
		   ,m.codigoEmpleado
		   ,m.IdMarcacion
		   ,m.CodigoSucursal
		   ,m.fecha
		   ,m.fecha Entrada
		   ,NULL Salida
		FROM Marcacion m UNION ALL  SELECT 
			ROW_NUMBER()  OVER (PARTITION BY CONVERT(DATE, fecha) , codigoEmpleado ORDER BY fecha DESC)  id
		   ,m.codigoEmpleado
		   ,m.IdMarcacion
		   ,m.CodigoSucursal
		   ,m.fecha
		   ,NULL Entrada
		   ,m.fecha Salida
		FROM Marcacion m)  m
	 INNER JOIN empleado e
		ON e.CodigoEmpleado = m.codigoEmpleado
	 INNER JOIN Sucursal s
		ON s.CodigoSucursal = m.CodigoSucursal

	WHERE m.id = 1
	 AND e.NombreEmpleado LIKE '%%'
	 AND e.CodigoSucursal = 1 
	GROUP BY m.codigoEmpleado
			,m.CodigoSucursal
			,e.NombreEmpleado
			,s.Nombre
			,e.CodigoHorario
			,CONVERT(DATE, m.fecha) 
			)  m
	ON CONVERT(date,m.FechaMarca) = CONVERT(date,r.Fecha)
 INNER JOIN Horario h on h.CodigoHorario = m.CodigoHorario
  LEFT JOIN ( 
 SELECT  j.CodigoEmpleado,tj.IsSalida,j.Fecha 
,SUM(CASE WHEN tj.IsSalida = 1 THEN Horas ELSE 0 END) Horas_Justificadas  
,SUM(CASE WHEN tj.IsSalida = 1 THEN 0 ELSE Horas END) Horas_extras 
from [dbo].[Justificacion] j 
 Inner JOIN TipoJustificacion tj ON j.CodigoTipoJustificacion = tj.CodigoTipoJustificacion
 Where j.IsEliminado  = 0 AND j.CodigoEstado = 2
 GROUP BY j.CodigoEmpleado,tj.IsSalida,j.Fecha  
)  j ON j.CodigoEmpleado = m.CodigoEmpleado  AND CONVERT(date,j.Fecha)  = Convert(date,m.FechaMarca) 

ORDER BY r.Fecha;
END