using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace http5101_final_project_n01353378
{
    public partial class EditPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                PagesDB db = new PagesDB();

                ShowPageContent(db);
            }
        }
        // We create the edit page so that we can edit data, through the Edit Page method we can set the new values the user updates.
        protected void Edit_Page(object sender, EventArgs e)
        {

            PagesDB db = new PagesDB();

            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;
            if (valid)
            {
                HTTP_Page new_page = new HTTP_Page();
               
                new_page.SetPagetitle(page_title.Text);
                new_page.SetPagebody(page_body.Text);
                new_page.SetPageauthor(page_author.Text);

                try
                {
                    db.EditPage(Int32.Parse(pageid), new_page);
                    Response.Redirect("ShowPage.aspx?pageid=" + pageid);
                }
                catch
                {
                    valid = false;
                }

            }

            if (!valid)
            {
                page_content.InnerHtml = "There was an error updating that page.";
            }

        }
        // The user has to be able to delete the page, we make a method so that it deletes it from the database.
        protected void Delete_Page(object sender, EventArgs e)
        {
            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            PagesDB db = new PagesDB();

            
            if (valid)
            {
                db.DeletePage(Int32.Parse(pageid));
                Response.Redirect("ManagePages.aspx");
            }
        }
        //We also need to show the the page content to be able to update the changes we make.
        protected void ShowPageContent(PagesDB db)
            {

                bool valid = true;
                string pageid = Request.QueryString["pageid"];
                if (String.IsNullOrEmpty(pageid)) valid = false;

                if (valid)
                {

                    HTTP_Page page_record = db.FindPage(Int32.Parse(pageid));


                    page_title.Text = page_record.GetPagetitle();
                    page_body.Text = page_record.GetPagebody();
                    page_author.Text = page_record.GetPageauthor();
                    page_date.InnerHtml = page_record.GetTimeStamp().ToString("yyyy-MM-dd");

                }
                else
                {
                    valid = false;
                }


                if (!valid)
                {
                    page_content.InnerHtml = "There was an error finding that Page.";
                }
            }
    }
}