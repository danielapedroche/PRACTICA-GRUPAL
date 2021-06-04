using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace WabiSabiWeb
{
    public partial class Pedido : System.Web.UI.Page
    {
        private bool resultado = false;
        protected void Page_Load(object sender, EventArgs e)
        {

            ENPedido en = new ENPedido();
            en.Nombre = (string)Session["Username"];

            en.Fecha = DateTime.Now;
            en.Estado = "pendiente de envio";

            if (Session["Direccion"] != null)
            {
                resultado = true;
                en.Direccion = TextBox1.Text;
            }
            else
                en.Direccion = TextBox1.Text;

            if (Session["CosteTotal"] != null)
            {
                en.Precio = 0;
            }
            else
                en.Precio = 0;

            en.createPedido();



        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultado = true;
        }

        protected void ConfirmarPedido_Click(object sender, EventArgs e)
        {

            if (resultado)
            {


                Label1.Text = "PEDIDO REALIZADO CON ÉXITO";

            }
            else
                Label1.Text = "Datos incorrectos";

        }
    }
}