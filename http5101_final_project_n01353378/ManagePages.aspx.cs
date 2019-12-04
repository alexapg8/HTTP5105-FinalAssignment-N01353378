using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace http5101_final_project_n01353378
{
    public partial class ManagePages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            page_result.InnerHtml = "";

            string searchkey = "";
            if (Page.IsPostBack)
            {
                searchkey = page_search.Text;
            }

            // We create the "search method" so that if the user wants to look for a specific page they can, 
            // either trough author name or page title
            string query = "select * from pagesmgmt";

            if (searchkey != "")
            {
                query += " WHERE pagetitle like '%" + searchkey + "%' ";
                query += " or pageauthor like '%" + searchkey + "%' ";
            }
            //We create the list query so that the pages where every new page is inserted into the list, 
            // showing the title, author, date published and a way to edit it.

                var db = new PagesDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                page_result.InnerHtml += "<div class=\"listitem\">";

                string pageid = row["pageid"];

                string pagetitle = row["pagetitle"];
                page_result.InnerHtml += "<div class=\"col4\"><a href=\"ShowPage.aspx?pageid=" + pageid + "\">" + pagetitle + "</a></div>";

                string pageauthor = row["pageauthor"];
                page_result.InnerHtml += "<div class=\"col4\">" + pageauthor + "</div>";

                string publisheddate = row["timestamp"];
                page_result.InnerHtml += "<div class=\"col4\">" + publisheddate + "</div>";

                page_result.InnerHtml += "<div class=\"col4last\"><a href=\"EditPage.aspx?pageid=" + pageid + "\">" + "Edit" + "</a>" + "</div>";

                page_result.InnerHtml += "</div>";
            }


        }

    }
}