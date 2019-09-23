using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapacitacionReportes
{
    class conexion
    {
        public OdbcConnection probarConexion()
        {
            // creacion de la conexion via ODBC
            OdbcConnection conn = new OdbcConnection("Dsn=reportes"); 
            try
            {
                conn.Open();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Surgió el siguiente problema: " + ex);
            }
            return conn;
        }
    }
}
