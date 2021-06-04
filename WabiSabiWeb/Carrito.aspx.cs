using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace WabiSabiWeb
{
    public partial class Carrito : System.Web.UI.Page
    {
        private bool resultado;
        protected void Page_Load(object sender, EventArgs e)
        {
            ENCarrito en = new ENCarrito();
            resultado = en.updateCarrito();
            if (resultado)
            {
                Label2.Text = en.Nombre;
                Label3.Text =" " + en.CosteTotal.ToString();
                Session["CosteTotal"] = en.CosteTotal.ToString();
            }
            else
                Label1.Text = "Error al mostrar el pedido";

            ENCarrito enu = new ENCarrito();
            resultado = enu.updateCarrito2();
            if (resultado)
            {
                Label4.Text = enu.Nombre;
                Label3.Text += " " + enu.CosteTotal.ToString();
                Session["CosteTotal"] = enu.CosteTotal.ToString();
            }
            else
                Label1.Text = "Error al mostrar el pedido";
            
        }
        protected void Update_Click(object sender, EventArgs e)
        {

            Response.Redirect("Pedido.aspx");
        }
    }
}