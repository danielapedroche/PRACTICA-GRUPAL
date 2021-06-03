using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace WabiSabiWeb
{
    public partial class Producto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Read_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(this.Codigo.Text);
            ENProducto enu = new ENProducto();
            if (enu.read())
            {
                Codigo.Text = enu.Codigo.ToString();
                Nombre.Text = enu.Nombre;
                Descripcion.Text = enu.Descripcion;
                Precio.Text = enu.Precio.ToString();
            }
            else
            {
                LabelRespuesta.Text = "Error, no se encuentra el producto.";
            }

        }
        protected void Update_Click(object sender, EventArgs e)
        {
            ENProducto enu = new ENProducto();
            enu.Codigo = int.Parse(Codigo.Text);
            enu.Nombre = Nombre.Text;
            enu.Descripcion = Descripcion.Text;
            enu.Precio = float.Parse(Precio.Text);
            if (enu.update())
            {
                LabelRespuesta.Text = "Actualizado el producto.";
            }
            else
            {
                LabelRespuesta.Text = "Error, no se ha podido actualizar el producto.";
            }

        }
        protected void Create_Click(object sender, EventArgs e)
        {
            if (Codigo.Text == "" || Nombre.Text == "" || Descripcion.Text == "" || Precio.Text == "")
            {
                LabelRespuesta.Text = "Completa todos los campos antes de crear un producto por favor";
            }
            else
            {

                ENProducto enu = new ENProducto();
                enu.Codigo = int.Parse(Codigo.Text);
                enu.Nombre = Nombre.Text;
                enu.Descripcion = Descripcion.Text;
                enu.Precio = float.Parse(Precio.Text);
                if (enu.create())
                {
                    LabelRespuesta.Text = "Producto creado.";
                }
                else
                {
                    LabelRespuesta.Text = "Error, no se ha podido crear el producto.";
                }
            }
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            ENProducto enu = new ENProducto();
            enu.Codigo = int.Parse(Codigo.Text);
            if (enu.delete())
            {
                Codigo.Text = "";
                Nombre.Text = "";
                Descripcion.Text = "";
                Precio.Text = "";
                LabelRespuesta.Text = "El producto ha sido eliminado.";
            }
            else
            {
                LabelRespuesta.Text = "Error, no se ha podido eliminar el producto.";
            }

        }
    }
}