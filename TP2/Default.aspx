<%@ Page Title="" Language="C#" MasterPageFile="~/Tp2.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="TP2._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="nomCo" ContentPlaceHolderID="Titre" runat="server">Veuillez vous identifier
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Contenu" runat="server">
    <asp:Login ID="LoginUser" runat="server" BackColor="LightGray" BorderColor="LightGray" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" TextLayout="TextOnTop" Width="717px" OnAuthenticate="LoginUser_Authenticate">
    <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
    <LoginButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" />
    <TextBoxStyle Font-Size="0.8em" />
    <TitleTextStyle BackColor="Orange" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
</asp:Login>
</asp:Content>
