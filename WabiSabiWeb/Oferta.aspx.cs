using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;
namespace WabiSabiWeb
{
    public partial class Oferta : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("InvitadOferta.aspx");
            }
            else if (Session["Username"].ToString() == "root")
            {
                Response.Redirect("RootOFERTA.aspx");
            }
            else
            {
                Response.Redirect("ClienteOFERTA.aspx");
            }
        }
    }
}
