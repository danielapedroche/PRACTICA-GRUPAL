using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;
using System.Threading;

namespace WabiSabiWeb
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void Create_Click(object sender, EventArgs e)
        {
            ENUsuario usuario = new ENUsuario();
            usuario.Nombre = Nombre.Text;
            usuario.Apellidos = Apellidos.Text;
            usuario.Nif = NIF.Text;
            usuario.Email = Email.Text;
            usuario.Direccion = Direccion.Text;
            usuario.Contrasenya = Contrasenya.Text;
            usuario.Telefono = Telefono.Text;
            usuario.Fechanac = FechaNac.SelectedDate;

            if (usuario.create())
            {
                Label1.Text = "Creación satisfactoria";
                Label1.Visible = true;
                Response.Redirect("ClienteOFERTA.aspx");
            }
            else
            {
                Label1.Text = "La creación no se realizó";
                Label1.Visible = true;
            }

        }
    }
}