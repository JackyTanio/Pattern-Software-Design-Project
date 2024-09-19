<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PSDProject.Views.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="welcomeText" runat="server" Text="Welcome, "></asp:Label>
    </div>

    <div>
        <h1>RAiso's Stationary</h1>
        <asp:GridView ID="stationeryGV" runat="server" AutoGenerateColumns="False" >
            <Columns>
                <asp:BoundField DataField="StationeryName" HeaderText="Name" SortExpression="StationeryName" />
                <asp:BoundField DataField="StationeryPrice" HeaderText="Price" SortExpression="StationeryPrice" />
            </Columns>
        </asp:GridView>
    </div>


</asp:Content>
