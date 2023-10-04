using App.Productos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Usuarios
{
    internal class UsuarioData
    {
        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuariosList = new List<Usuario>();
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            var query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    var usuario = new Usuario();
                                    usuario.Id = Convert.ToInt32(reader["Id"]);
                                    usuario.Nombre = reader["Nombre"].ToString();
                                    usuario.Apellido = reader["Apellido"].ToString();
                                    usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                                    usuario.Contraseña = reader["Contraseña"].ToString();
                                    usuario.Mail = reader["Mail"].ToString();

                                    usuariosList.Add(usuario);
                                }
                            }
                        }
                    }

                    connection.Close();
                }

                return usuariosList;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static Usuario ObtenerUsuario(long usuarioId)
        {
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            string query = "SELECT * FROM Usuario WHERE Id = @Id";
            Usuario usuario = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt) { Value = usuarioId });

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            usuario = new Usuario();

                            if (reader.Read())
                            {
                                usuario.Id = Convert.ToInt32(reader["Id"]);
                                usuario.Nombre = reader["Nombre"].ToString();
                                usuario.Apellido = reader["Apellido"].ToString();
                                usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                                usuario.Contraseña = reader["Contraseña"].ToString();
                                usuario.Mail = reader["Mail"].ToString();
                            };
                        }
                    }

                    connection.Close();
                }

                return usuario;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void CrearUsuario(Usuario usuario)
        {
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            string query = "INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contraseña, Mail)" +
                           "VALUES(@Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                        command.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                        command.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                        command.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                        command.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void ModificarUsuario(Usuario usuario)
        {
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            string query = "UPDATE Usuario " +
                        "SET Nombre = @Nombre, Apellido = @Apellido, NombreUsuario = @NombreUsuario, Contraseña = @Contraseña, Mail = @Mail " +
                        "WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                        command.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                        command.Parameters.Add(new SqlParameter("@NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                        command.Parameters.Add(new SqlParameter("@Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                        command.Parameters.Add(new SqlParameter("@Mail", SqlDbType.VarChar) { Value = usuario.Mail });
                        command.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt) { Value = usuario.Id });

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void EliminarUsuario(Usuario usuario)
        {
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            string query = "DELETE FROM Usuario WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt) { Value = usuario.Id });

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
