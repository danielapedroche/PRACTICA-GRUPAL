using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class CADCarrito
    {
        private string constring { get; set; }

        public CADCarrito()
        {
            constring = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
        }
        public bool createCarrito(ENCarrito en)
        {
            SqlConnection conn = null;
            String comando = "Insert into Carrito(Id) VALUES ('" + en.Id + "')";

            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            finally
            {
                if (conn != null) conn.Close(); // Se asegura de cerrar la conexión.
            }

            return true;
        }
        public bool updateCarrito(ENCarrito en)
        {
            SqlConnection conn = null;
            String comando = "Select * from Producto where pedido = '" + 1 + "'";

            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        en.Nombre = en.Nombre + " " + dr.GetString(1) + " " + dr.GetDouble(3) + "€ ,";
                        en.CosteTotal = en.CosteTotal + dr.GetDouble(3);
                    }

                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                dr.Close();
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            finally
            {
                if (conn != null) conn.Close(); // Se asegura de cerrar la conexión.
            }
            return true;
        }
        public bool updateCarrito2(ENCarrito en)
        {
            SqlConnection conn = null;
            String comando = "Select * from Menu where pedido = '" + 1 + "'";

            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        en.Nombre = en.Nombre + " " + dr.GetString(1) + " " + dr.GetDouble(2) + "€ ,";
                        en.CosteTotal = en.CosteTotal + dr.GetDouble(2);
                    }

                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                dr.Close();
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            finally
            {
                if (conn != null) conn.Close(); // Se asegura de cerrar la conexión.
            }
            return true;
        }
        public bool readCarrito(ENCarrito en)
        {
            SqlConnection conn = null;
            String comando = "Select * from Carrito where Id = '" + en.Id + "'";

            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    //mostrar los productos del carrito?
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                dr.Close();
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            finally
            {
                if (conn != null) conn.Close(); // Se asegura de cerrar la conexión.
            }
            return true;
        }
        public bool deleteCarrito(ENCarrito en)
        {
            SqlConnection conn = null;
            String comando = "Delete from Carrito where Id = '" + en.Id + "'";

            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            finally
            {
                if (conn != null) conn.Close(); // Se asegura de cerrar la conexión.
            }

            return true;
        }
    }
}
