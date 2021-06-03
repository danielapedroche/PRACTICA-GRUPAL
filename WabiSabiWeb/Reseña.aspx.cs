
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace WabiSabiWeb
{
    public partial class Reseña : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Read_Click(object sender, EventArgs e)
        {
            ENReseña enu = new ENReseña();
            enu.Id = int.Parse(Numero.Text);
            if (enu.read())
            {
                Numero.Text = enu.Id.ToString();
                Contenido.Text = enu.Contenido;

            }
            else
            {
                LabelRespuesta.Text = "Error, no se encuentra la suscripcion.";
            }
        }
        protected void Update_Click(object sender, EventArgs e)
        {
            ENReseña enu = new ENReseña();
            enu.Id = int.Parse(Numero.Text);
            enu.Contenido = Contenido.Text;
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
            if (Numero.Text == "" || Contenido.Text == "")
            {
                LabelRespuesta.Text = "Completa todos los campos antes de crear un menu por favor";
            }
            else
            {

                ENReseña enu = new ENReseña();
                enu.Id = int.Parse(Numero.Text);
                enu.Contenido = enu.Contenido;
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

            ENReseña enu = new ENReseña();
            enu.Id = int.Parse(Numero.Text);
            if (enu.delete())
            {
                Numero.Text = "";
                Contenido.Text = "";
                LabelRespuesta.Text = "La suscripcion ha sido eliminada.";
            }
            else
            {
                LabelRespuesta.Text = "Error, no se ha podido eliminar la suscripcion.";
            }
        }
    }
}