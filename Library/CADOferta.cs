using System;
using System.Data.SqlClient;
using System.Configuration;


namespace Library
{
    class CADOferta
    {
        private string constring;
        public CADOferta()
        {
            constring = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
        }
        public bool create(ENOferta en) { 
     
            SqlConnection conn = new SqlConnection(constring);
            string comando = "Insert Into [dbo].[Oferta] (id, tipo, descripcion, solousuarios) " + "VALUES ('" + en.Codigo + "', '" +  en.Tipo + "', '" + en.Descripcion + "', '" + en.Solousuarios + "')";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                int affected = cmd.ExecuteNonQuery();
                conn.Close();
                if(affected == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Error: " + e);
                return false;
            }
            
        }
        public bool read(ENOferta en)
        {
            SqlConnection conn = new SqlConnection(constring);
            String comando = "select * from [dbo].[Oferta] where id='" + en.Codigo + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (int.Parse(dr["id"].ToString()) == en.Codigo)
                    {

                        en.Tipo = dr["tipo"].ToString();
                        en.Descripcion = dr["descripcion"].ToString();
                        en.Solousuarios = int.Parse(dr["solousuarios"].ToString());
                        dr.Close();
                        conn.Close();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
        }
        public bool update(ENOferta en)
        {
            SqlConnection conn = new SqlConnection(constring);
            string comando = "UPDATE [dbo].[Oferta] " + "SET tipo = '" + en.Tipo + "', descripcion = '" + en.Descripcion + "', solousuarios = '" + en.Solousuarios +  "' " + "WHERE id = " + en.Codigo;
       
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
              int affected =   cmd.ExecuteNonQuery();
                conn.Close();
                if (affected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
           
        }
        public bool delete(ENOferta en)
        {
            SqlConnection conn = new SqlConnection(constring); ;
            string comando = "Delete from [dbo].[Oferta] where id = '" + en.Codigo + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
               int num =  cmd.ExecuteNonQuery();
                if(num == 1)
                {
                    conn.Close();
                    return true;
                }
                else{
                    conn.Close();
                    return false;
                }

            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
          
        }

        public string invitados (int solousuarios)
        {
            String comando = "";
            string s = "";
            SqlConnection conn = new SqlConnection(constring);
            if (solousuarios == 0)
                comando = "select * from [dbo].[Oferta] where solousuarios='" + solousuarios + "'";
            else
                comando = "select * from [dbo].[Oferta]";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    s = " " +  s + dr["tipo"].ToString();
                    s = s + " " + dr["descripcion"].ToString() + "<br />";

                }
                return s;
            }
            catch (Exception)
            {
                conn.Close();
                return "error";
            }
        }



    }
}
