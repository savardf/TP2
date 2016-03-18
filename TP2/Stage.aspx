<%@ Page Title="" Language="C#" MasterPageFile="~/Tp2.Master" AutoEventWireup="true" CodeBehind="Stage.aspx.cs" Inherits="TP2.Stage1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="nomUser" ContentPlaceHolderID="Titre" runat="server">
    Stage de <asp:Literal ID="lilnomUser" runat="server"></asp:Literal>
</asp:Content>
<asp:Content ID="Tableau" ContentPlaceHolderID="Contenu" runat="server" >
        <asp:LinqDataSource ID="dsClient" runat="server" ContextTypeName="TP2.GestionStagesDataContext" EntityTypeName="" TableName="Stages" Where="StagiaireId == @StagiaireId">
        <WhereParameters>
            <asp:SessionParameter Name="StagiaireId" SessionField="ClientId" Type="Int32" />
        </WhereParameters>
    </asp:LinqDataSource>
    <asp:Literal ID="litText" runat="server"></asp:Literal>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="dsClient" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Titre" HeaderText="Titre" SortExpression="Titre" />
            <asp:BoundField DataField="Début" HeaderText="Début" SortExpression="Début" />
            <asp:BoundField DataField="Fin" HeaderText="Fin" SortExpression="Fin" />
            <asp:BoundField DataField="Commentaire" HeaderText="Commentaire" SortExpression="Commentaire" />
            <asp:BoundField DataField="SupersiveurId" HeaderText="SupersiveurId" SortExpression="SupersiveurId" />
            <asp:BoundField DataField="StagiaireId" HeaderText="StagiaireId" SortExpression="StagiaireId" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
</asp:Content>
