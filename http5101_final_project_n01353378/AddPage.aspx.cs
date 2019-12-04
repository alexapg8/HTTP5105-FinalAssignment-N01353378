using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace http5101_final_project_n01353378
{
    public partial class AddPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //We haave to set up a method so that when the user clicks submit, the information goes into the database and into the "Manage Pages" page.
        //We set up connection to the PagesDB and SET the information into the values.
            protected void Add_Page(object sender, EventArgs e)
            {
                
                PagesDB db = new PagesDB();

                
                HTTP_Page new_page = new HTTP_Page();
                
               
                new_page.SetPagetitle(newpage_title.Text);
                new_page.SetPagebody(newpage_body.Text);
                new_page.SetPageauthor(newpage_author.Text);
                new_page.SetTimeStamp(DateTime.Now);

                
                db.AddPage(new_page);


                Response.Redirect("ManagePages.aspx");
            }
        
    }
}