<%@ Page Title="Edit Page" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="EditPage.aspx.cs" Inherits="http5101_final_project_n01353378.EditPage" %>
<asp:Content ID="editpage" ContentPlaceHolderID="body" runat="server">
    <div id="page_content" runat="server">
        <!-- We create an EDIT page so that the user can update or change only the title, body or author name -->
    <h2>Edit Page</h2>
    <div class="frow">
        <label>Title</label>
        <asp:TextBox runat="server" ID="page_title"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter a title" ControlToValidate="page_title"></asp:RequiredFieldValidator>
    </div>
    <div class="frow">
        <label>Body</label>
        <div>
          <asp:TextBox TextMode="MultiLine" Columns="80" Rows="20" runat="server" ID="page_body"></asp:TextBox>
          <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter text" ControlToValidate="page_body"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="frow">
        <label>Author</label>
        <asp:TextBox runat="server" ID="page_author"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter your name" ControlToValidate="page_author"></asp:RequiredFieldValidator>
    </div>
    <div class="frow">
        <label>Published:</label>
        <span id="page_date" runat="server"></span><br />
    </div>
    <div>
        <asp:Button OnClick="Edit_Page" CssClass="button" Text="Update" runat="server" />
        <asp:Button OnClick="Delete_Page" CssClass="button" Text="Delete" runat="server" />

    </div>
    </div>
</asp:Content>
