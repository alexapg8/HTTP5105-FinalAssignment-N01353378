using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace http5101_final_project_n01353378
{
    public partial class ShowPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PagesDB db = new PagesDB();
            
            ShowPageContent(db);
           // when the page is loading we show the content created by the author
            }
            protected void ShowPageContent(PagesDB db)
            {

            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            if (valid)
            {

                HTTP_Page page_record = db.FindPage(Int32.Parse(pageid));
                // using the FindPage method we get the page

                page_title.InnerHtml = page_record.GetPagetitle();
                page_body.InnerHtml = page_record.GetPagebody();
                page_author.InnerHtml = page_record.GetPageauthor();
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