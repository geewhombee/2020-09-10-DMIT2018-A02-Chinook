<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="P04_DDLofTracks.aspx.cs" Inherits="WebApp.SamplePages.P04_DDLofTracks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ODS_TrackList" DataTextField="Name" DataValueField="TrackId"></asp:DropDownList>
        <%--<asp:Label ID="Label1" runat="server" Text="Select Artist"></asp:Label>&nbsp;&nbsp;
        <asp:DropDownList ID="DDLofArtists1" runat="server"
            DataSourceID="ODS_DDLofArtists"
            DataTextField="ArtistName"
            DataValueField="ArtistId"
            Width="350px">
            <asp:ListItem Value="0">Hey Man</asp:ListItem>
        </asp:DropDownList>&nbsp;&nbsp;
        <asp:LinkButton
            ID="DisplaySelectedInfo1"
            runat="server" OnClick="DisplaySelectedInfo1_Click">
            Display Selected Info 1
        </asp:LinkButton>--%>
    </div>
    <br /><br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_TrackList" GridLines="Horizontal"
        CssClass="table ">
        <Columns>
            <asp:BoundField DataField="TrackId" HeaderText="TrackId" SortExpression="TrackId"></asp:BoundField>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
            <asp:BoundField DataField="AlbumId" HeaderText="AlbumId" SortExpression="AlbumId"></asp:BoundField>
            <asp:BoundField DataField="MediaTypeId" HeaderText="MediaTypeId" SortExpression="MediaTypeId"></asp:BoundField>
            <asp:BoundField DataField="GenreId" HeaderText="GenreId" SortExpression="GenreId"></asp:BoundField>
            <asp:BoundField DataField="Composer" HeaderText="Composer" SortExpression="Composer"></asp:BoundField>
            <asp:BoundField DataField="Milliseconds" HeaderText="Milliseconds" SortExpression="Milliseconds"></asp:BoundField>
            <asp:BoundField DataField="Bytes" HeaderText="Bytes" SortExpression="Bytes"></asp:BoundField>
            <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="ArtistId" HeaderText="ArtistId" SortExpression="ArtistId"></asp:BoundField>
            <asp:BoundField DataField="ArtistName" HeaderText="ArtistName" SortExpression="ArtistName"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
        <Columns>
            <asp:BoundField DataField="AlbumId" HeaderText="AlbumId" SortExpression="AlbumId"></asp:BoundField>
            <asp:BoundField DataField="AlbumTitle" HeaderText="AlbumTitle" SortExpression="AlbumTitle"></asp:BoundField>
            <asp:BoundField DataField="ArtistId" HeaderText="ArtistId" SortExpression="ArtistId"></asp:BoundField>
            <asp:BoundField DataField="AlbumReleaseYear" HeaderText="AlbumReleaseYear" SortExpression="AlbumReleaseYear"></asp:BoundField>
            <asp:BoundField DataField="AlbumReleaseLabel" HeaderText="AlbumReleaseLabel" SortExpression="AlbumReleaseLabel"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ODS_TrackList" runat="server"
        OldValuesParameterFormatString="original_{0}"
        SelectMethod="Track_List"
        TypeName="ChinookSystem.BLL.TrackController">
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Artist_List" TypeName="ChinookSystem.BLL.ArtistController"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Albums_List" TypeName="ChinookSystem.BLL.AlbumController"></asp:ObjectDataSource>
</asp:Content>
