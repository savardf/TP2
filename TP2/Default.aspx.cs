using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["ClientId"] != null)
            {
                BDGestionStages bd = new BDGestionStages();
               
                Administrateur a = bd.GetAdministrateur();
                Stagiaire sta = bd.GetStagiaire(Convert.ToInt32(this.Session["ClientId"]));
                Superviseur sup = bd.GetSuperviseur(Convert.ToInt32(this.Session["ClientId"]));

                if (a!=null)
                {
                    this.Response.Redirect("~/Administration.aspx");
                }
                
                else if (sta != null)
                {
                   
                    this.Response.Redirect("~/Stage.aspx");
                   
                }
                else
                {
                    this.Response.Redirect("~/ProfilSuperviseur.aspx");
                }
               

            }
            LoginUser.RememberMeSet = true;
            if (Request.Cookies["UserName"] != null && Request.Cookies["Password"] != null)
            {
                
                LoginUser.UserName = Request.Cookies["UserName"].Value;
                TextBox txtTemp = (TextBox)LoginUser.FindControl("Password");
                txtTemp.Attributes["Value"] = Request.Cookies["Password"].Value;
            }    
       
        }

        protected void LoginUser_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (LoginUser.RememberMeSet)
            {
                Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(30);
                Response.Cookies["Password"].Expires = DateTime.Now.AddDays(30);
            }
            else
            {
                Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["Password"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Cookies["UserName"].Value = LoginUser.UserName.Trim();
            Response.Cookies["Password"].Value = LoginUser.Password.Trim();

            BDGestionStages bd = new BDGestionStages();
            Administrateur a = bd.GetAdministrateur();
            Stagiaire st = bd.GetStagiaire(LoginUser.UserName);  
            Superviseur su = bd.GetSuperviseur(LoginUser.UserName);
            if (a != null)
            {
                if (a.MotDePasse == LoginUser.Password)
                {
                    this.Session["ClientId"] = a.Id;
                    this.Response.Redirect("~/Administration.aspx");
                }
            }    
            else if (st != null)   
            {
                if (st.MotDePasse == LoginUser.Password)
                {
                    this.Session["ClientId"] = st.Id;
                    this.Response.Redirect("~/Stage.aspx");
                }
            }  
            else if (su != null)
            {
                if (su.MotDePasse == LoginUser.Password)
                {
                    this.Session["ClientId"] = su.Id;
                    this.Response.Redirect("~/ProfilSuperviseur.aspx");
                }
            }
    
            else
            {
                this.Response.Redirect("~/noAccess.aspx");
            }
            
        }
    }
}