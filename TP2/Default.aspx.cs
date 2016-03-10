using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //voici un test
            BDGestionStages bd = new BDGestionStages();

            Stage stg = bd.GetStage(1);
            Response.Write("Voici les infos du stage:<br />Titre :" + stg.Titre + "<br />Nom sup. " + stg.Superviseur.Nom);

            Superviseur spu = stg.Superviseur;
            Response.Write("<br />Voici les infos du superviseur:<br />Nom " + spu.Nom + " <br />courriel: " + spu.Courriel);
        }
    }
}
