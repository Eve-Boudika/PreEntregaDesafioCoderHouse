using PreEntregaCoderHouse.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreEntregaCoderHouse.Repository
{
    internal class ProductoRepository : DataBase
    {

        public List<Producto> GetProductos()
        {
            string cmdText = "SELECT * FROM Producto";
            List<Producto> products = new List<Producto>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                Producto producto = new Producto();

                                producto.Id = Convert.ToInt64(dataReader["Id"]);
                                producto.Descripciones = dataReader["Descripciones"].ToString();
                                producto.Costo = Convert.ToDecimal(dataReader["Costo"]);
                                producto.PrecioVenta = Convert.ToDecimal(dataReader["PrecioVenta"]);
                                producto.Stock = Convert.ToInt32(dataReader["Stock"]);
                                producto.IdUsuario = Convert.ToInt64(dataReader["IdUsuario"]);

                                products.Add(producto);
                            }
                        }
                    }
                }
            }
            return products;
        }
    }
}
