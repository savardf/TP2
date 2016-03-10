﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18408
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TP2
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GestionStages")]
	public partial class GestionStagesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void InsertStage(Stage instance);
    partial void UpdateStage(Stage instance);
    partial void DeleteStage(Stage instance);
    partial void InsertSuperviseur(Superviseur instance);
    partial void UpdateSuperviseur(Superviseur instance);
    partial void DeleteSuperviseur(Superviseur instance);
    partial void InsertStagiaire(Stagiaire instance);
    partial void UpdateStagiaire(Stagiaire instance);
    partial void DeleteStagiaire(Stagiaire instance);
    partial void InsertAdministrateur(Administrateur instance);
    partial void UpdateAdministrateur(Administrateur instance);
    partial void DeleteAdministrateur(Administrateur instance);
    #endregion
		
		public GestionStagesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["GestionStagesConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public GestionStagesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GestionStagesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GestionStagesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GestionStagesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Stage> Stages
		{
			get
			{
				return this.GetTable<Stage>();
			}
		}
		
		public System.Data.Linq.Table<Superviseur> Superviseurs
		{
			get
			{
				return this.GetTable<Superviseur>();
			}
		}
		
		public System.Data.Linq.Table<Stagiaire> Stagiaires
		{
			get
			{
				return this.GetTable<Stagiaire>();
			}
		}
		
		public System.Data.Linq.Table<Administrateur> Administrateurs
		{
			get
			{
				return this.GetTable<Administrateur>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Stage")]
	public partial class Stage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Titre;
		
		private System.DateTime _Début;
		
		private System.DateTime _Fin;
		
		private string _Commentaire;
		
		private int _SupersiveurId;
		
		private int _StagiaireId;
		
		private EntityRef<Superviseur> _Superviseur;
		
		private EntityRef<Stagiaire> _Stagiaire;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitreChanging(string value);
    partial void OnTitreChanged();
    partial void OnDébutChanging(System.DateTime value);
    partial void OnDébutChanged();
    partial void OnFinChanging(System.DateTime value);
    partial void OnFinChanged();
    partial void OnCommentaireChanging(string value);
    partial void OnCommentaireChanged();
    partial void OnSupersiveurIdChanging(int value);
    partial void OnSupersiveurIdChanged();
    partial void OnStagiaireIdChanging(int value);
    partial void OnStagiaireIdChanged();
    #endregion
		
		public Stage()
		{
			this._Superviseur = default(EntityRef<Superviseur>);
			this._Stagiaire = default(EntityRef<Stagiaire>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Titre", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Titre
		{
			get
			{
				return this._Titre;
			}
			set
			{
				if ((this._Titre != value))
				{
					this.OnTitreChanging(value);
					this.SendPropertyChanging();
					this._Titre = value;
					this.SendPropertyChanged("Titre");
					this.OnTitreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Début", DbType="DateTime NOT NULL")]
		public System.DateTime Début
		{
			get
			{
				return this._Début;
			}
			set
			{
				if ((this._Début != value))
				{
					this.OnDébutChanging(value);
					this.SendPropertyChanging();
					this._Début = value;
					this.SendPropertyChanged("Début");
					this.OnDébutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fin", DbType="DateTime NOT NULL")]
		public System.DateTime Fin
		{
			get
			{
				return this._Fin;
			}
			set
			{
				if ((this._Fin != value))
				{
					this.OnFinChanging(value);
					this.SendPropertyChanging();
					this._Fin = value;
					this.SendPropertyChanged("Fin");
					this.OnFinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Commentaire", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Commentaire
		{
			get
			{
				return this._Commentaire;
			}
			set
			{
				if ((this._Commentaire != value))
				{
					this.OnCommentaireChanging(value);
					this.SendPropertyChanging();
					this._Commentaire = value;
					this.SendPropertyChanged("Commentaire");
					this.OnCommentaireChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SupersiveurId", DbType="Int NOT NULL")]
		public int SupersiveurId
		{
			get
			{
				return this._SupersiveurId;
			}
			set
			{
				if ((this._SupersiveurId != value))
				{
					if (this._Superviseur.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSupersiveurIdChanging(value);
					this.SendPropertyChanging();
					this._SupersiveurId = value;
					this.SendPropertyChanged("SupersiveurId");
					this.OnSupersiveurIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StagiaireId", DbType="Int NOT NULL")]
		public int StagiaireId
		{
			get
			{
				return this._StagiaireId;
			}
			set
			{
				if ((this._StagiaireId != value))
				{
					if (this._Stagiaire.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStagiaireIdChanging(value);
					this.SendPropertyChanging();
					this._StagiaireId = value;
					this.SendPropertyChanged("StagiaireId");
					this.OnStagiaireIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Superviseur_Stage", Storage="_Superviseur", ThisKey="SupersiveurId", OtherKey="Id", IsForeignKey=true)]
		public Superviseur Superviseur
		{
			get
			{
				return this._Superviseur.Entity;
			}
			set
			{
				Superviseur previousValue = this._Superviseur.Entity;
				if (((previousValue != value) 
							|| (this._Superviseur.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Superviseur.Entity = null;
						previousValue.Stages.Remove(this);
					}
					this._Superviseur.Entity = value;
					if ((value != null))
					{
						value.Stages.Add(this);
						this._SupersiveurId = value.Id;
					}
					else
					{
						this._SupersiveurId = default(int);
					}
					this.SendPropertyChanged("Superviseur");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Stagiaire_Stage", Storage="_Stagiaire", ThisKey="StagiaireId", OtherKey="Id", IsForeignKey=true)]
		public Stagiaire Stagiaire
		{
			get
			{
				return this._Stagiaire.Entity;
			}
			set
			{
				Stagiaire previousValue = this._Stagiaire.Entity;
				if (((previousValue != value) 
							|| (this._Stagiaire.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Stagiaire.Entity = null;
						previousValue.Stages.Remove(this);
					}
					this._Stagiaire.Entity = value;
					if ((value != null))
					{
						value.Stages.Add(this);
						this._StagiaireId = value.Id;
					}
					else
					{
						this._StagiaireId = default(int);
					}
					this.SendPropertyChanged("Stagiaire");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Superviseur")]
	public partial class Superviseur : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nom;
		
		private string _Téléphone;
		
		private string _Courriel;
		
		private string _NomUtilisateur;
		
		private string _MotDePasse;
		
		private EntitySet<Stage> _Stages;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNomChanging(string value);
    partial void OnNomChanged();
    partial void OnTéléphoneChanging(string value);
    partial void OnTéléphoneChanged();
    partial void OnCourrielChanging(string value);
    partial void OnCourrielChanged();
    partial void OnNomUtilisateurChanging(string value);
    partial void OnNomUtilisateurChanged();
    partial void OnMotDePasseChanging(string value);
    partial void OnMotDePasseChanged();
    #endregion
		
		public Superviseur()
		{
			this._Stages = new EntitySet<Stage>(new Action<Stage>(this.attach_Stages), new Action<Stage>(this.detach_Stages));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this.OnNomChanging(value);
					this.SendPropertyChanging();
					this._Nom = value;
					this.SendPropertyChanged("Nom");
					this.OnNomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Téléphone", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Téléphone
		{
			get
			{
				return this._Téléphone;
			}
			set
			{
				if ((this._Téléphone != value))
				{
					this.OnTéléphoneChanging(value);
					this.SendPropertyChanging();
					this._Téléphone = value;
					this.SendPropertyChanged("Téléphone");
					this.OnTéléphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Courriel", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Courriel
		{
			get
			{
				return this._Courriel;
			}
			set
			{
				if ((this._Courriel != value))
				{
					this.OnCourrielChanging(value);
					this.SendPropertyChanging();
					this._Courriel = value;
					this.SendPropertyChanged("Courriel");
					this.OnCourrielChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NomUtilisateur", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string NomUtilisateur
		{
			get
			{
				return this._NomUtilisateur;
			}
			set
			{
				if ((this._NomUtilisateur != value))
				{
					this.OnNomUtilisateurChanging(value);
					this.SendPropertyChanging();
					this._NomUtilisateur = value;
					this.SendPropertyChanged("NomUtilisateur");
					this.OnNomUtilisateurChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MotDePasse", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string MotDePasse
		{
			get
			{
				return this._MotDePasse;
			}
			set
			{
				if ((this._MotDePasse != value))
				{
					this.OnMotDePasseChanging(value);
					this.SendPropertyChanging();
					this._MotDePasse = value;
					this.SendPropertyChanged("MotDePasse");
					this.OnMotDePasseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Superviseur_Stage", Storage="_Stages", ThisKey="Id", OtherKey="SupersiveurId")]
		public EntitySet<Stage> Stages
		{
			get
			{
				return this._Stages;
			}
			set
			{
				this._Stages.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Stages(Stage entity)
		{
			this.SendPropertyChanging();
			entity.Superviseur = this;
		}
		
		private void detach_Stages(Stage entity)
		{
			this.SendPropertyChanging();
			entity.Superviseur = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Stagiaire")]
	public partial class Stagiaire : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nom;
		
		private string _Téléphone;
		
		private string _Courriel;
		
		private string _NomUtilisateur;
		
		private string _MotDePasse;
		
		private EntitySet<Stage> _Stages;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNomChanging(string value);
    partial void OnNomChanged();
    partial void OnTéléphoneChanging(string value);
    partial void OnTéléphoneChanged();
    partial void OnCourrielChanging(string value);
    partial void OnCourrielChanged();
    partial void OnNomUtilisateurChanging(string value);
    partial void OnNomUtilisateurChanged();
    partial void OnMotDePasseChanging(string value);
    partial void OnMotDePasseChanged();
    #endregion
		
		public Stagiaire()
		{
			this._Stages = new EntitySet<Stage>(new Action<Stage>(this.attach_Stages), new Action<Stage>(this.detach_Stages));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this.OnNomChanging(value);
					this.SendPropertyChanging();
					this._Nom = value;
					this.SendPropertyChanged("Nom");
					this.OnNomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Téléphone", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Téléphone
		{
			get
			{
				return this._Téléphone;
			}
			set
			{
				if ((this._Téléphone != value))
				{
					this.OnTéléphoneChanging(value);
					this.SendPropertyChanging();
					this._Téléphone = value;
					this.SendPropertyChanged("Téléphone");
					this.OnTéléphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Courriel", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Courriel
		{
			get
			{
				return this._Courriel;
			}
			set
			{
				if ((this._Courriel != value))
				{
					this.OnCourrielChanging(value);
					this.SendPropertyChanging();
					this._Courriel = value;
					this.SendPropertyChanged("Courriel");
					this.OnCourrielChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NomUtilisateur", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string NomUtilisateur
		{
			get
			{
				return this._NomUtilisateur;
			}
			set
			{
				if ((this._NomUtilisateur != value))
				{
					this.OnNomUtilisateurChanging(value);
					this.SendPropertyChanging();
					this._NomUtilisateur = value;
					this.SendPropertyChanged("NomUtilisateur");
					this.OnNomUtilisateurChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MotDePasse", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string MotDePasse
		{
			get
			{
				return this._MotDePasse;
			}
			set
			{
				if ((this._MotDePasse != value))
				{
					this.OnMotDePasseChanging(value);
					this.SendPropertyChanging();
					this._MotDePasse = value;
					this.SendPropertyChanged("MotDePasse");
					this.OnMotDePasseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Stagiaire_Stage", Storage="_Stages", ThisKey="Id", OtherKey="StagiaireId")]
		public EntitySet<Stage> Stages
		{
			get
			{
				return this._Stages;
			}
			set
			{
				this._Stages.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Stages(Stage entity)
		{
			this.SendPropertyChanging();
			entity.Stagiaire = this;
		}
		
		private void detach_Stages(Stage entity)
		{
			this.SendPropertyChanging();
			entity.Stagiaire = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Administrateur")]
	public partial class Administrateur : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _NomUtilisateur;
		
		private string _MotDePasse;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNomUtilisateurChanging(string value);
    partial void OnNomUtilisateurChanged();
    partial void OnMotDePasseChanging(string value);
    partial void OnMotDePasseChanged();
    #endregion
		
		public Administrateur()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NomUtilisateur", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string NomUtilisateur
		{
			get
			{
				return this._NomUtilisateur;
			}
			set
			{
				if ((this._NomUtilisateur != value))
				{
					this.OnNomUtilisateurChanging(value);
					this.SendPropertyChanging();
					this._NomUtilisateur = value;
					this.SendPropertyChanged("NomUtilisateur");
					this.OnNomUtilisateurChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MotDePasse", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string MotDePasse
		{
			get
			{
				return this._MotDePasse;
			}
			set
			{
				if ((this._MotDePasse != value))
				{
					this.OnMotDePasseChanging(value);
					this.SendPropertyChanging();
					this._MotDePasse = value;
					this.SendPropertyChanged("MotDePasse");
					this.OnMotDePasseChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
