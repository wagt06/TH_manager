using MD.Tools;
using Microsoft.EntityFrameworkCore;

namespace MD
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            string directorio = Directory.GetCurrentDirectory();

            string sql = CargarArchivoText.LeerArchivo(directorio + "\\Sql\\objetos.sql");

            using (DbContext db = new DbContext())
            {
                db.Database.Migrate();

                db.Database.ExecuteSqlRaw($"IF object_id('dbo.SP_Marcaciones') IS NOT NULL BEGIN " +
                    $" DROP PROCEDURE dbo.SP_Marcaciones; " +
                    $" END");

                db.Database.ExecuteSqlRaw(sql);
            }

            Application.Run(new FrmLogin());
        }
    }
}