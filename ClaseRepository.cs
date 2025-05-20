using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

public class ClaseRepository
{
    public bool RegistrarClase(string nombre, string descripcion, int duracion, string dificultad, int capacidad)
    {
        try
        {
            SqlConnection con = ConexionBD.ObtenerConexion();
            if (con.State == ConnectionState.Closed)
                con.Open();

            string query = "INSERT INTO Clases (nombre_clase, Descripcion, Duracion_min, Dificultad, Capacidad) " +
                           "VALUES (@Nombre, @Descripcion, @Duracion, @Dificultad, @Capacidad)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@Duracion", duracion);
                cmd.Parameters.AddWithValue("@Dificultad", dificultad);
                cmd.Parameters.AddWithValue("@Capacidad", capacidad);

                cmd.ExecuteNonQuery();
            }

            con.Close();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool EliminarClase(int id)
    {
        try
        {
            SqlConnection con = ConexionBD.ObtenerConexion();
            if (con.State == ConnectionState.Closed)
                con.Open();

            string query = "DELETE FROM Clases WHERE IDClase = @ID";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                int filas = cmd.ExecuteNonQuery();
                con.Close();
                return filas > 0;
            }
        }
        catch
        {
            return false;
        }
    }
}