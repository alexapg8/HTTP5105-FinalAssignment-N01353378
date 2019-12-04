<%@ Page Title="New Page" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddPage.aspx.cs" Inherits="http5101_final_project_n01353378.AddPage" %>
<asp:Content ID="new_page" ContentPlaceHolderID="body" runat="server">
    <!-- We need to create a page where a user can insert their content to create a new "page" -->
    <h2>New Page</h2>
    <div>
    <div class="frow">
        <!-- A page needs a Title, we use a required field validator to make sure the user inserts something -->
        <label>Title</label>
        <asp:TextBox runat="server" ID="newpage_title"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter a title" ControlToValidate="newpage_title"></asp:RequiredFieldValidator>
    </div>
    <div class="frow">
        <!-- The body should be longer text, we use a multiline textbox with a required field validator -->
        <label>Body</label>
        <div>
           <asp:TextBox TextMode="MultiLine" Columns="80" Rows="20" runat="server" ID="newpage_body"></asp:TextBox>
           <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter text" ControlToValidate="newpage_body"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="frow">
        <!-- we need the users name to save the page under their author's name -->
        <label>Author</label>
        <asp:TextBox runat="server" ID="newpage_author"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter your name" ControlToValidate="newpage_author"></asp:RequiredFieldValidator>
    </div>
    <div class="add_button">
        <!--Finally we submit the page and it goes into the database -->
        <asp:Button OnClick="Add_Page" CssClass="button" Text="Publish" runat="server" />
        <!-- and a button to cancel in case they don't want to publish anymore, making sure that it ignores the validation -->
        <asp:Button CssClass="button" Text="Cancel" CausesValidation="false" PostBackUrl="~/ManagePages.aspx" runat="server" />
    </div>
    </div>
</asp:Content>
