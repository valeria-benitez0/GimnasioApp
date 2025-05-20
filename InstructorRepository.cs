using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

public class InstructorRepository
{
    public bool RegistrarInstructor(string nombre, string apellido, string especialidad, DateTime horario, string estado, string email, string contrasena)
    {
        try
        {
            SqlConnection con = ConexionBD.ObtenerConexion();
            if (con.State == ConnectionState.Closed)
                con.Open();

            string query = "INSERT INTO Instructores (Nombre, Apellido, Especialidad, Horario, Estado, Email, Contrasena) " +
                           "VALUES (@Nombre, @Apellido, @Especialidad, @Horario, @Estado, @Email, @Contrasena)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Especialidad", especialidad);
                cmd.Parameters.AddWithValue("@Horario", horario);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);

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