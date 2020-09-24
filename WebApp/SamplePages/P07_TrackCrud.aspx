<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="P07_TrackCrud.aspx.cs" Inherits="WebApp.SamplePages.P07_TrackCrud" %>

<%@ Register Src="~/UserControls/MessageUserControl.ascx" TagPrefix="uc1" TagName="MessageUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <h2>Track Crud Page</h2>
    </div>
    <br />

    <div class="row">
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
        <asp:ListView ID="ListView1" runat="server"></asp:ListView>
    </div>
    <br />

    <div class="row">
        <uc1:MessageUserControl runat="server" ID="MessageUserControl" />
    </div>
    <br />

</asp:Content>
