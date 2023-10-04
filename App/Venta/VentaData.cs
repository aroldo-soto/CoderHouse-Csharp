using App.Productos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Venta
{
    internal class VentaData
    {
        public static List<Venta> ListarVentas()
        {
            List<Venta> ventasList = new List<Venta>();
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            var query = "SELECT Id, Comentarios, IdUsuario FROM Venta";

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
                                    var venta = new Venta();
                                    venta.Id = Convert.ToInt32(reader["Id"]);
                                    venta.Comentarios = reader["Comentarios"].ToString();
                                    venta.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);

                                    ventasList.Add(venta);
                                }
                            }
                        }
                    }

                    connection.Close();
                }

                return ventasList;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static Venta ObtenerVenta(long ventaId)
        {
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            string query = "SELECT * FROM Venta WHERE Id = @Id";
            Venta venta = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt) { Value = ventaId });

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            venta = new Venta();

                            if (reader.Read())
                            {
                                venta.Id = Convert.ToInt32(reader["Id"]);
                                venta.Comentarios = reader["Comentarios"].ToString();
                                venta.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                            };
                        }
                    }

                    connection.Close();
                }

                return venta;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void CrearVenta(Venta venta)
        {
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            string query = "INSERT INTO Venta (Comentarios, IdUsuario)" +
                            "VALUES(@Comentarios, @IdUsuario)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        command.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = venta.IdUsuario });

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
        public static void ModificarVenta(Venta venta)
        {
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            string query = "UPDATE Venta " +
                        "SET Comentarios = @Comentarios, IdUsuario = @IdUsuario " +
                        "WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        command.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.BigInt) { Value = venta.IdUsuario });
                        command.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt) { Value = venta.Id });

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
        public static void EliminarVenta(Venta venta)
        {
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            string query = "DELETE FROM Venta WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt) { Value = venta.Id });

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
