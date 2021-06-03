
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
                LabelRespuesta.Text = "Error, no se encuentra la reseña.";
            }
        }
        protected void Update_Click(object sender, EventArgs e)
        {
            ENReseña enu = new ENReseña();
            enu.Id = int.Parse(Numero.Text);
            enu.Contenido = Contenido.Text;
            if (enu.update())
            {
                LabelRespuesta.Text = "Actualizado la reseña.";
            }
            else
            {
                LabelRespuesta.Text = "Error, no se ha podido actualizar la reseña.";
            }

        }
        protected void Create_Click(object sender, EventArgs e)
        {
            if (Numero.Text == "" || Contenido.Text == "")
            {
                LabelRespuesta.Text = "Completa todos los campos antes de crear una reseña por favor";
            }
            else
            {

                ENReseña enu = new ENReseña();
                enu.Id = int.Parse(Numero.Text);
                enu.Contenido = Contenido.Text;
                if (enu.create())
                {
                    LabelRespuesta.Text = "Reseña creada.";
                }
                else
                {
                    LabelRespuesta.Text = "Error, no se ha podido crear la reseña.";
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
                LabelRespuesta.Text = "La reseña ha sido eliminada.";
            }
            else
            {
                LabelRespuesta.Text = "Error, no se ha podido eliminar la reseña.";
            }
        }
    }
}