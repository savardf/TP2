using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2
{
    public partial class Stage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BDGestionStages bd = new BDGestionStages();
            Stagiaire c = bd.GetStagiaire((int)this.Session["ClientId"]);
            this.lilnomUser.Text = c.Nom;
           

        }

        protected void LinqDataSource1_Selecting(object sender, LinqDataSourceSelectEventArgs e)
        {

        }

    }
}