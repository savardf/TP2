using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace TP2
{
    public partial class Tp2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        
            var NomPage = Path.GetFileName(Request.FilePath);

            if (NomPage.ToUpper() != "DEFAULT.ASPX" && NomPage.ToUpper() != "ACCESNONAUTHO1.ASPX")
            {               
                if (this.Session["ClientId"] == null)
                {
                    this.Response.Redirect("~/noAccess.aspx");
                }
            }
        }

        protected void lbDeconnecter_Click(object sender, EventArgs e)
        {
            this.Session.Abandon();
            this.Response.Redirect("~/");
        }
    }
}