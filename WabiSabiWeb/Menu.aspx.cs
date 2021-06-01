using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace WabiSabiWeb
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Read_Click(object sender, EventArgs e)
        {
            ENMenu enu = new ENMenu();
            enu.Id = int.Parse(Numero.Text);
            if (enu.read())
            {
                Numero.Text = enu.Id.ToString();
                Nombre.Text = enu.Nombre;
                Precio.Text = enu.Precio.ToString();
            }
            else
            {
                LabelRespuesta.Text = "Error, no se encuentra el menu.";
            }

        }
        protected void Update_Click(object sender, EventArgs e)
        {
            ENMenu enu = new ENMenu();
            enu.Id = int.Parse(Numero.Text);
            enu.Nombre = Nombre.Text;
            enu.Precio = float.Parse(Precio.Text);
            if (enu.update())
            {
                LabelRespuesta.Text = "Actualizado el menu.";
            }
            else
            {
                LabelRespuesta.Text = "Error, no se ha podido actualizar el menu.";
            }

        }
        protected void Create_Click(object sender, EventArgs e)
        {
            if (Numero.Text == "" || Nombre.Text == "" || Precio.Text == "")
            {
                LabelRespuesta.Text = "Completa todos los campos antes de crear un menu por favor";
            }
            else
            {

                ENMenu enu = new ENMenu();
                enu.Id = int.Parse(Numero.Text);
                enu.Nombre = Nombre.Text;
                enu.Precio = float.Parse(Precio.Text);
                if (enu.create())
                {
                    LabelRespuesta.Text = "Menu creado.";
                }
                else
                {
                    LabelRespuesta.Text = "Error, no se ha podido crear el menu.";
                }
            }
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            ENMenu enu = new ENMenu();
            enu.Id = int.Parse(Numero.Text);
            if (enu.delete())
            {
                Numero.Text = "";
                Nombre.Text = "";
                Precio.Text = "";
                LabelRespuesta.Text = "El menu ha sido eliminado.";
            }
            else
            {
                LabelRespuesta.Text = "Error, no se ha podido eliminar el menu.";
            }

        }
    }
}