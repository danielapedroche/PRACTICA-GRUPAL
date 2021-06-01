using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace WabiSabiWeb
{
    public partial class clienteOFERTA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ENOferta oferta = new ENOferta();
            oferta.Solousuarios = 0;
            Label1.Text = oferta.invitados();
            Label1.Visible = true;
        }
    }
}