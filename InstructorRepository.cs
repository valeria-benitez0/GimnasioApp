using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

public class InstructorRepository
{
    public bool RegistrarInstructor(string nombre, string apellido, string especialidad, DateTime horario, string estado)
    {
        try
        {
            SqlConnection con = ConexionBD.ObtenerConexion();
            if (con.State == ConnectionState.Closed)
                con.Open();

            string query = "INSERT INTO Instructores (Nombre, Apellido, Especialidad, Horario, Estado) " +
                           "VALUES (@Nombre, @Apellido, @Especialidad, @Horario, @Estado)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Especialidad", especialidad);
                cmd.Parameters.AddWithValue("@Horario", horario);
                cmd.Parameters.AddWithValue("@Estado", estado);

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

    public bool EliminarInstructor(int id)
    {
        try
        {
            SqlConnection con = ConexionBD.ObtenerConexion();
            if (con.State == ConnectionState.Closed)
                con.Open();

            string query = "DELETE FROM Instructores WHERE IDInstructor = @ID";

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