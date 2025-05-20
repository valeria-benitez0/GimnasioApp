using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

public class MiembroRepository
{
    public bool RegistrarMiembro(string nombre, string apellido, string email, string telefono, DateTime fechaNacimiento, string contrasena)
    {
        try
        {
            SqlConnection con = ConexionBD.ObtenerConexion();
            if (con.State == ConnectionState.Closed)
                con.Open();

            string query = "INSERT INTO Miembros (Nombre, Apellido, Email, Telefono, Fecha_nacimiento, Estado_Membresia, Contrasena) " +
                           "VALUES (@Nombre, @Apellido, @Email, @Telefono, @FechaNacimiento, 'Activa', @Contrasena)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
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

    public bool EliminarMiembro(int id)
    {
        try
        {
            SqlConnection con = ConexionBD.ObtenerConexion();
            if (con.State == ConnectionState.Closed)
                con.Open();

            string query = "DELETE FROM Miembros WHERE IDMiembro = @ID";

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