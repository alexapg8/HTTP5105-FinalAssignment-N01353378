using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace http5101_final_project_n01353378
{
    public partial class ListPages : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PagesDB db = new PagesDB();
            ListFeatPages(db);
        }
        protected void ListFeatPages(PagesDB db)
        {
            // To get the pages to show on the header and footer as they are created we run a query in the method
            //with a foreach so that everytime a page is added to the databas it also shows on the header.
            string query = "select * from pagesmgmt";
            List<Dictionary<String, String>> rs = db.List_Query(query);

            foreach (Dictionary<String, String> row in rs)
            {
              
                list_pages.InnerHtml += "<a id=\"navdes\" href=\"ShowPage.aspx?pageid="+ row["pageid"]+ "\" >"+"Page " + row["pageid"]+"</a>";

            }
        }
    }
}