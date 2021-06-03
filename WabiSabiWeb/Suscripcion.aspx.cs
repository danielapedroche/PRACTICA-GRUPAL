using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace WabiSabiWeb
{
    public partial class Supscripcion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Read_Click(object sender, EventArgs e)
        {
            ENSuscripcion enu = new ENSuscripcion();
            enu.Id = int.Parse(Numero.Text);
            if (enu.read())
            {
                Numero.Text = enu.Id.ToString();
                Tipo.Text = enu.Tipo;
       
            }
            else
            {
                LabelRespuesta.Text = "Error, no se encuentra la suscripcion.";
            }
        }
        protected void Update_Click(object sender, EventArgs e)
        {
            ENSuscripcion enu = new ENSuscripcion();
            enu.Id = int.Parse(Numero.Text);
            enu.Tipo = Tipo.Text;
            if (enu.update())
            {
                LabelRespuesta.Text = "Actualizado la suscripcion.";
            }
            else
            {
                LabelRespuesta.Text = "Error, no se ha podido actualizar la suscripcion.";
            }

        }
        protected void Create_Click(object sender, EventArgs e)
        {
            if (Numero.Text == "" || Tipo.Text == "")
            {
                LabelRespuesta.Text = "Completa todos los campos antes de crear un menu por favor";
            }
            else
            {

                ENSuscripcion enu = new ENSuscripcion();
                enu.Id = int.Parse(Numero.Text);
                enu.Tipo = Tipo.Text;
                if (enu.create())
                {
                    LabelRespuesta.Text = "Suscripción creada.";
                }
                else
                {
                    LabelRespuesta.Text = "Error, no se ha podido crear la suscripcion.";
                }
            }
        }
        protected void Delete_Click(object sender, EventArgs e)
        {

            ENSuscripcion enu = new ENSuscripcion();
            enu.Id = int.Parse(Numero.Text);
            if (enu.delete())
            {
                Numero.Text = "";
                Tipo.Text = "";
                LabelRespuesta.Text = "La suscripcion ha sido eliminada.";
            }
            else
            {
                LabelRespuesta.Text = "Error, no se ha podido eliminar la suscripcion.";
            }
        }
    }
}