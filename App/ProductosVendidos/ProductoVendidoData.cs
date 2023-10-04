using App.Productos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ProductosVendidos
{
    internal class ProductoVendidoData
    {
        public static List<ProductoVendido> ListarProductosVendidos()
        {
            List<ProductoVendido> productosVendidosList = new List<ProductoVendido>();
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            var query = "SELECT Id, IdProducto, Stock, IdVenta FROM ProductoVendido";

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
                                    var productoVendido = new ProductoVendido();
                                    productoVendido.Id = Convert.ToInt32(reader["Id"]);
                                    productoVendido.IdProducto = Convert.ToInt32(reader["IdProducto"]);
                                    productoVendido.Stock = Convert.ToDecimal(reader["Stock"]);
                                    productoVendido.IdVenta = Convert.ToInt32(reader["IdVenta"]);

                                    productosVendidosList.Add(productoVendido);
                                }
                            }
                        }
                    }

                    connection.Close();
                }

                return productosVendidosList;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static ProductoVendido ObtenerProductoVendido(long productoVendidoId)
        {
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            string query = "SELECT * FROM ProductoVendido WHERE Id = @Id";
            ProductoVendido productoVendido = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt) { Value = productoVendidoId });

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            productoVendido = new ProductoVendido();

                            if (reader.Read())
                            {
                                productoVendido.Id = Convert.ToInt32(reader["Id"]);
                                productoVendido.IdProducto = Convert.ToInt32(reader["IdProducto"]);
                                productoVendido.Stock = Convert.ToDecimal(reader["Stock"]);
                                productoVendido.IdVenta = Convert.ToInt32(reader["IdVenta"]);
                            };
                        }
                    }

                    connection.Close();
                }

                return productoVendido;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            string query = "INSERT INTO ProductoVendido (IdProducto, Stock, IdVenta)" +
                        "VALUES(@IdProducto, @Stock, @IdVenta)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = productoVendido.IdProducto });
                        command.Parameters.Add(new SqlParameter("Stock", SqlDbType.Decimal) { Value = productoVendido.Stock });
                        command.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.BigInt) { Value = productoVendido.IdVenta });

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
        public static void ModificarProductoVendido(ProductoVendido productoVendido)
        {
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            string query = "UPDATE ProductoVendido " +
                        "SET IdProducto = @IdProducto, Stock = @Stock, IdVenta  = @IdVenta " +
                        "WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.BigInt) { Value = productoVendido.IdProducto });
                        command.Parameters.Add(new SqlParameter("@Stock", SqlDbType.Decimal) { Value = productoVendido.Stock });
                        command.Parameters.Add(new SqlParameter("@IdVenta", SqlDbType.BigInt) { Value = productoVendido.IdVenta });
                        command.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt) { Value = productoVendido.Id });

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
        public static void EliminarProductoVendido(ProductoVendido productoVendido)
        {
            string connectionString = @"Server=DESKTOP-JL3BETG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True";
            string query = "DELETE FROM ProductoVendido WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt) { Value = productoVendido.Id });

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
