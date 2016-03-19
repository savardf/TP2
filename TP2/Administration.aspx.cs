using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2
{
    public partial class Administration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BDGestionStages bd = new BDGestionStages();
            Administrateur admin = bd.GetAdministrateur();
            if (admin.NomUtilisateur != "Admin")
            {
                this.Response.Redirect("~/default.aspx");
            }

        }

        protected void gvSuperviseurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int index = (int)this.gvSuperviseurs.SelectedDataKey.Value;
            BDGestionStages bd = new BDGestionStages();
            Superviseur mySuperviseur = bd.GetSuperviseur(index);
            this.txtNom.Text = mySuperviseur.Nom;
            this.txtUserName.Text = mySuperviseur.NomUtilisateur;
            this.txtEmail.Text = mySuperviseur.Courriel;
            this.txtPhone.Text = mySuperviseur.Téléphone;
            


        }

     

        protected void ddlSelecGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ddlSelecGroup.SelectedIndex == 1)
            {
                this.gvStagiaires.Visible = false;
                this.gvSuperviseurs.Visible = true;
                
            }
            else
            {
                this.gvSuperviseurs.Visible = false;
                this.gvStagiaires.Visible = true;
            }

            
        }

        protected void gvStagiaires_SelectedIndexChanged1(object sender, EventArgs e)
        {
            int index = (int)this.gvStagiaires.SelectedDataKey.Value;
            BDGestionStages bd = new BDGestionStages();
            Stagiaire myStagiaire = bd.GetStagiaire(index);
            this.txtNom.Text = myStagiaire.Nom;
            this.txtUserName.Text = myStagiaire.NomUtilisateur;
            this.txtEmail.Text = myStagiaire.Courriel;
            this.txtPhone.Text = myStagiaire.Téléphone;
           
        }

        protected void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.txtNom.Text = "";
            this.txtUserName.Text = "";
            this.txtEmail.Text = "";
            this.txtPhone.Text = "";
            
        }

        protected void btnSoumettre_Click(object sender, EventArgs e)
        {
            BDGestionStages bd = new BDGestionStages();
            bool exist = false;
            int id=0;
            Stagiaire myStagiaire;
            Superviseur mySuperviseur;

            foreach (Stagiaire item in bd.GetAllStagiaires())
            {
                if (item.NomUtilisateur == this.txtUserName.Text)
                {
                    exist = true;
                    myStagiaire = bd.GetStagiaire(this.txtUserName.Text);
                    id = myStagiaire.Id;
                }
            }

            foreach (Superviseur item in bd.GetAllSuperviseurs())
            {
                if (item.NomUtilisateur == this.txtUserName.Text)
                {
                    exist = true;
                    mySuperviseur = bd.GetSuperviseur(this.txtUserName.Text);
                    id = mySuperviseur.Id;
                }
            }



            if (exist == true)
            {
                if(this.ddlSelecGroup.SelectedIndex == 0)
                {
                    bd.GetStagiaire(id).Nom = this.txtNom.Text;
                    bd.GetStagiaire(id).Téléphone = this.txtPhone.Text;
                    bd.GetStagiaire(id).Courriel = this.txtEmail.Text;
                    
                }
                if(this.ddlSelecGroup.SelectedIndex == 1)
                {
                    bd.GetSuperviseur(id).Nom = this.txtNom.Text;
                    bd.GetSuperviseur(id).Téléphone = this.txtPhone.Text;
                    bd.GetSuperviseur(id).Courriel = this.txtEmail.Text;
                }
                
            }
            else
            {
                if (this.ddlSelecGroup.SelectedIndex == 0)
                {
                    myStagiaire = new Stagiaire();
                    myStagiaire.Nom = this.txtNom.Text;
                    myStagiaire.NomUtilisateur = this.txtUserName.Text;
                    myStagiaire.Courriel = this.txtEmail.Text;
                    myStagiaire.Téléphone = this.txtPhone.Text;
                    myStagiaire.MotDePasse = "cisco123";
                    bd.Ajouter(myStagiaire);
                }
                if (this.ddlSelecGroup.SelectedIndex == 1)
                {
                    mySuperviseur = new Superviseur();
                    mySuperviseur.Nom = this.txtNom.Text;
                    mySuperviseur.NomUtilisateur = this.txtUserName.Text;
                    mySuperviseur.Courriel = this.txtEmail.Text;
                    mySuperviseur.Téléphone = this.txtPhone.Text;
                    mySuperviseur.MotDePasse = "cisco123";
                    bd.Ajouter(mySuperviseur);
                }
            }
            bd.Sauvegarder();
            Response.Redirect(Request.RawUrl);

        }
    }
}