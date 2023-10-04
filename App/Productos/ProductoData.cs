using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Productos
{
    public static class ProductoData
    {
        public static List<Producto> ListarProductos()
        {
            List<Producto> productList = new List<Producto>();
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            var query = "SELECT Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario FROM Producto";

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
                                    var producto = new Producto();
                                    producto.Id = Convert.ToInt32(reader["Id"]);
                                    producto.Descripciones = reader["Descripciones"].ToString();
                                    producto.Costo = Convert.ToDecimal(reader["Costo"]);
                                    producto.PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"]);
                                    producto.Stock = Convert.ToDecimal(reader["Stock"]);
                                    producto.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);

                                    productList.Add(producto);
                                }
                            }
                        }
                    }

                    connection.Close();
                }

                return productList;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static Producto ObtenerProducto(long productId)
        {
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            string query = "SELECT * FROM Producto WHERE Id = @Id";
            Producto producto = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt) { Value = productId });

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            producto = new Producto();

                            if (reader.Read())
                            {
                                producto.Id = Convert.ToInt32(reader["Id"]);
                                producto.Descripciones = reader["Descripciones"].ToString();
                                producto.Costo = Convert.ToDecimal(reader["Costo"]);
                                producto.PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"]);
                                producto.Stock = Convert.ToDecimal(reader["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                            };
                        }
                    }

                    connection.Close();
                }

                return producto;

            } catch (Exception ex)
            {
                throw;
            }
        }
        public static void CrearProducto(Producto producto)
        {
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            string query = "INSERT INTO Producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario)" +
                        "VALUES(@Descripciones, @Costo, @PrecioVenta, @Stock, @IdUsuario)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.Descripciones });
                        command.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = producto.Costo });
                        command.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                        command.Parameters.Add(new SqlParameter("Stock", SqlDbType.Decimal) { Value = producto.Stock });
                        command.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });

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
        public static void ModificarProducto(Producto producto)
        {
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            string query = "UPDATE Producto " +
                        "SET Descripciones = @Descripciones, Costo = @Costo, PrecioVenta = @PrecioVenta, Stock = @Stock, IdUsuario = @IdUsuario " +
                        "WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Descripciones", SqlDbType.VarChar) { Value = producto.Descripciones });
                        command.Parameters.Add(new SqlParameter("@Costo", SqlDbType.Decimal) { Value = producto.Costo });
                        command.Parameters.Add(new SqlParameter("@PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                        command.Parameters.Add(new SqlParameter("@Stock", SqlDbType.Decimal) { Value = producto.Stock });
                        command.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });
                        command.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt) { Value = producto.Id });

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
        public static void EliminarProducto(Producto producto)
        {
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            string query = "DELETE FROM Producto WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt) { Value = producto.Id });

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
