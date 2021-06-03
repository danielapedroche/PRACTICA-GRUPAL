using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;



namespace Library
{
    class CADProducto
    {
        private string constring;
        public CADProducto()
        {
            constring = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
        }
        public bool create(ENProducto en)
        {
            SqlConnection conn = new SqlConnection(constring);
            string comando = "Insert Into Producto (codigo, nombre, descripcion, precio) " + "VALUES ('" + en.Codigo + "', '" + en.Nombre + "', '" + en.Descripcion + "','" + en.Precio + "')";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Error: " + e);
                return false;
            }
            return true;
        }
        public bool read(ENProducto en)
        {
            SqlConnection conn = new SqlConnection(constring);
            String comando = "select * from [dbo].[Producto] where codigo='" + en.Codigo + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (int.Parse(dr["codigo"].ToString()) == en.Codigo)
                {
                    en.Codigo = int.Parse(dr["codigo"].ToString());
                    en.Nombre = dr["nombre"].ToString();
                    en.Descripcion = dr["descripcion"].ToString();
                    en.Precio = float.Parse(dr["precio"].ToString());
                    dr.Close();
                    conn.Close();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
        }
        public bool update(ENProducto en)
        {
            SqlConnection conn = new SqlConnection(constring);
            string comando = "UPDATE [dbo].[Producto] " + "SET nombre = '" + en.Nombre + "',  descripcion = '" + en.Descripcion + "',  precio = " + en.Precio + " where Codigo ='" + en.Codigo + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Error: " + e);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        public bool delete(ENProducto en)
        {
            SqlConnection conn = new SqlConnection(constring); ;
            string comando = "Delete from [dbo].[Producto] where codigo = '" + en.Codigo + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
    }
}