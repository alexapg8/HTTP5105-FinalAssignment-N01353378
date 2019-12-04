<%@ Page Title="Show Page" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ShowPage.aspx.cs" Inherits="http5101_final_project_n01353378.ShowPage" %>
<asp:Content ID="ShowPage" ContentPlaceHolderID="body" runat="server">
    <!-- Here we will VIEW the page the user created -->
     <div id="page_content" runat="server">
        <div id="page_header">
          <H2 id="page_title" runat="server"></H2><br />
        </div>
        <div id="page_body_content">
          <p id="page_body" runat="server"></p><br />
        </div>
        <div id="post_info">
          <span id="page_author" runat="server"></span><br />
          <span id="page_date" runat="server"></span><br />
        </div>
        <div id="editpage_button">
          <!-- to be able to edit the page if they want to or delete it, we use the edit page -->
          <a class="button" href="EditPage.aspx?pageid=<%= Request.QueryString["pageid"] %>">Edit</a>
        </div>
     </div>
</asp:Content>
