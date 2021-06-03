using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace WabiSabiWeb
{
    public partial class RootOFERTA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Read_Click(object sender, EventArgs e)
        {

            int codigo = int.Parse(this.Codigo.Text);
            ENOferta oferta = new ENOferta(codigo);
            oferta.read();
            string s = "La oferta con código" + oferta.Codigo.ToString() + " es: " + oferta.Tipo + " " + oferta.Descripcion;
            if(oferta.Solousuarios == 0)
            {
                s = s + " La oferta es válida para todo tipo de clientes.";
            }
            else
            {
                s = s + " Solo los clientes registrados podrán usar esta oferta";
            }
            Label1.Text = s;
            Label1.Visible = true;
            }
        protected void Update_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(this.Codigo.Text);
            ENOferta oferta = new ENOferta(codigo, this.Tipo.Text, this.Descripcion.Text, this.DropDownList1.SelectedIndex);
            if (oferta.update())
            {
                Label1.Text = "Actualización satisfactoria";
                Label1.Visible = true;
            }
            else
            {
                Label1.Text = "La actualización no se realizó";
                Label1.Visible = true;
            }

        }
        protected void Create_Click(object sender, EventArgs e)
        {
            ENOferta oferta = new ENOferta(Tipo.Text, Descripcion.Text, DropDownList1.SelectedIndex);


            if (oferta.create())
            {
                Label2.Text = "Creación satisfactoria";
                Label2.Visible = true;
            }
            else
            {
                Label2.Text = "La creación no se realizó";
                Label2.Visible = true;
            }

        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(Codigo.Text);
            ENOferta oferta = new ENOferta(codigo);
            if (oferta.delete())
            {
                Label1.Text = "Borrado Satisfactorio";
                Label1.Visible = true;
            }
            else
            {
                Label1.Text = "No se encontró la oferta con id: " + codigo;
                Label1.Visible = true;
            }

        }
    }
}