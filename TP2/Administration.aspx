<%@ Page Title="" Language="C#" MasterPageFile="~/Tp2.Master" AutoEventWireup="true" CodeBehind="Administration.aspx.cs" Inherits="TP2.Administration" %>
<asp:Content ID="header" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="h1" ContentPlaceHolderID="Titre" runat="server">
    <asp:Literal ID="AdminUsername" runat="server"></asp:Literal>
</asp:Content>
<asp:Content ID="tableau" ContentPlaceHolderID="Contenu" runat="server">
    <asp:LinqDataSource ID="LinqDataSuperviseur" runat="server" ContextTypeName="TP2.GestionStagesDataContext" EntityTypeName="" Select="new (Téléphone, Id, Nom, Courriel, NomUtilisateur, Stages)" TableName="Superviseurs">
    </asp:LinqDataSource>
    <asp:LinqDataSource ID="LindDataStagiaires" runat="server" ContextTypeName="TP2.GestionStagesDataContext" EntityTypeName="" Select="new (Nom, Téléphone, Courriel, NomUtilisateur, Stages, Id)" TableName="Stagiaires">
    </asp:LinqDataSource>
    <asp:DropDownList ID="ddlSelecGroup" runat="server" OnSelectedIndexChanged="ddlSelecGroup_SelectedIndexChanged" AutoPostBack="True">
        <asp:ListItem>Stagiaires</asp:ListItem>
        <asp:ListItem>Superviseurs</asp:ListItem>
    </asp:DropDownList>
    <asp:GridView ID="gvSuperviseurs" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvSuperviseurs_SelectedIndexChanged" AutoGenerateSelectButton="True" DataKeyNames="Id" DataSourceID="LinqDataSuperviseur" Visible="False">
        <Columns>
            <asp:BoundField DataField="NomUtilisateur" HeaderText="NomUtilisateur" ReadOnly="True" SortExpression="NomUtilisateur" />
            <asp:BoundField DataField="Nom" HeaderText="Nom" ReadOnly="True" SortExpression="Nom" />
            <asp:BoundField DataField="Courriel" HeaderText="Courriel" ReadOnly="True" SortExpression="Courriel" />
            <asp:BoundField DataField="Téléphone" HeaderText="Téléphone" ReadOnly="True" SortExpression="Téléphone" />
        </Columns>
    </asp:GridView>
    <asp:GridView ID="gvStagiaires" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" DataKeyNames="Id" DataSourceID="LindDataStagiaires" OnSelectedIndexChanged="gvStagiaires_SelectedIndexChanged1" style="margin-right: 0px">
        <Columns>
            <asp:BoundField DataField="NomUtilisateur" HeaderText="NomUtilisateur" ReadOnly="True" SortExpression="NomUtilisateur" />
            <asp:BoundField DataField="Nom" HeaderText="Nom" ReadOnly="True" SortExpression="Nom" />
            <asp:BoundField DataField="Courriel" HeaderText="Courriel" ReadOnly="True" SortExpression="Courriel" />
            <asp:BoundField DataField="Téléphone" HeaderText="Téléphone" ReadOnly="True" SortExpression="Téléphone" />
        </Columns>
    </asp:GridView>
    <div>
    <asp:Label ID="LabelNom" runat="server" Text="Nom: "></asp:Label>
    <asp:TextBox ID="txtNom" runat="server" Width="188px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" ControlToValidate="txtNom" ErrorMessage="*"></asp:RequiredFieldValidator>
        </div>
     <div>
    <asp:Label ID="LabelUsername" runat="server" Text="User Name: "></asp:Label>
         <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsersame" runat="server" ControlToValidate="txtUserName" ErrorMessage="*"></asp:RequiredFieldValidator>
         </div>
    
     <div>
    <asp:Label ID="LabelEmail" runat="server" Text="Courriel: "></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="*"></asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="EmailValidator" runat="server" ControlToValidate="txtEmail" ErrorMessage="Entrez une address courriel valide" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
         </div>
      <div>
    <asp:Label ID="LabelPhone" runat="server" Text="Téléphone: "></asp:Label>
    <asp:TextBox ID="txtPhone" runat="server" TextMode="Phone" ValidationGroup=" "></asp:TextBox>
          <asp:RegularExpressionValidator ID="phoneValidator" runat="server" ControlToValidate="txtPhone" ErrorMessage="Entrez un numéro de téléphone valide" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
          </div>
      <div>
          <asp:Literal ID="ErrorMsgLit" runat="server"></asp:Literal>
          </div>
      <div>
          <asp:Button ID="btnAjouter" runat="server" Text="Ajouter" />
    <asp:Button ID="btnSoumettre" runat="server" Text="Modifier" OnClick="btnSoumettre_Click" />
          <asp:Button ID="btnAnnuler" runat="server" OnClick="btnAnnuler_Click" Text="Annuler" />
          </div>
</asp:Content>
