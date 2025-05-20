using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

public class ConexionBD
{
    private static SqlConnection conexion;

    private ConexionBD() { }

    public static SqlConnection ObtenerConexion()
    {
        if (conexion == null)
        {
            conexion = new SqlConnection("Server=localhost;Database=GimnasioDB;Trusted_Connection=True;");
        }
        return conexion;
    }
}