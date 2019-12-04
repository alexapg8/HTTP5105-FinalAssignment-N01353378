<%@ Page Title="Manage Pages" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ManagePages.aspx.cs" Inherits="http5101_final_project_n01353378.ManagePages" %>
<asp:Content ID="ManagePages" ContentPlaceHolderID="body" runat="server">
    <h2>Manage Pages</h2>
    <!-- we create a web form to "Manage" all the pages created -->
      <div class="addnewlink">
        <a href="~/AddPage.aspx" for="addnewpage" runat="server">Add New</a>
      </div>
      <div class="pages_table" runat="server">
         <div id="search_box">
            <asp:label for="page_search" CssClass="search_button" runat="server">Search:</asp:label>
            <asp:TextBox ID="page_search" runat="server"></asp:TextBox>
            <asp:Button runat="server" CssClass="button" text="SUBMIT"/>
         </div>
         <div class="listitem">
            <div class="col4">Title</div>
            <div class="col4">Author</div>
            <div class="col4">Published</div>
            <div class="col4last">Action</div>
        </div>
        <div id="page_result" runat="server">

        </div>
    </div>
</asp:Content>
