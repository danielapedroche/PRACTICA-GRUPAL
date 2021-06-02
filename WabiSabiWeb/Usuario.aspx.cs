using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace WabiSabiWeb
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Read_Click(object sender, EventArgs e)
        {
            ENUsuario usuario = new ENUsuario(Nif.Text, Contrasenya.Text);
            if (usuario.read())
            {
                Session["Username"] = usuario.Nombre;
                Response.Redirect("Default.aspx");
            }
            else
            {
                LabelRespuesta.Text = "Usuario no encontrado";
                LabelRespuesta.Visible = true;
            }
        }
        protected void Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }
    }
}