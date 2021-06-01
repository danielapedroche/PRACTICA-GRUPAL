using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using Library;

namespace WabiSabiWeb
{
    public partial class InvitadOfertaaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ENOferta oferta = new ENOferta();
                oferta.Solousuarios = 0;
                Label1.Text = oferta.invitados();
                Label1.Visible = true;
            }
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Usuario.aspx"); 
        }
    }
}