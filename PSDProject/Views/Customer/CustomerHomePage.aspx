<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/CustomerNavBar.Master" AutoEventWireup="true" CodeBehind="CustomerHomePage.aspx.cs" Inherits="PSDProject.Views.Customer.CustomerHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>RAiso's Stationary</h1>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
    <Columns>
        <asp:BoundField DataField="StationeryID" HeaderText="No" SortExpression="StationeryID" />
        <asp:BoundField DataField="StationeryName" HeaderText="Name" SortExpression="StationeryName"/>
        
        
        <asp:CommandField ButtonType="Button" HeaderText="Detail" ShowHeader="True" ShowSelectButton="True" />
        
        
    </Columns>

</asp:GridView>
</asp:Content>
