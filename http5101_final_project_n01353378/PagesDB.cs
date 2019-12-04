using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Diagnostics;
namespace http5101_final_project_n01353378
{
    public class PagesDB
    {
        // We connect to the database we created on PhpMyAdmin trough this class
        private static string User { get { return "root"; } }
        private static string Database { get { return "pagesmgmtdb"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }
        private static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port;
            }
        }
        
        //We have to create our methods on the database class so that we can use them trughout the pages
        public List<Dictionary<String, String>> List_Query(string query)
        {
            //we create a connection to the database so that we can get the information it holds
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();
            try
            {
                Debug.WriteLine("Connection Initialized...");
                Debug.WriteLine("Attempting to execute query " + query);
                Connect.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                MySqlDataReader resultset = cmd.ExecuteReader();


                while (resultset.Read())
                {
                    Dictionary<String, String> Row = new Dictionary<String, String>();
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Row.Add(resultset.GetName(i), resultset.GetString(i));

                    }

                    ResultSet.Add(Row);
                }
                resultset.Close();


            }
            catch (Exception ex)
            {
                //We create debugs so that if something goes wrong we know on what part it was
                Debug.WriteLine("Something went wrong in the List_Query method!");
                Debug.WriteLine(ex.ToString());

            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return ResultSet;
        }
        


        // we create a method so that we can add a page which directly sends the information to the table in the database.
        public void AddPage (HTTP_Page new_page)
        {
            //We write the query to instruct the method what we want it to do
            string query = "insert into pagesmgmt (pagetitle, pagebody, pageauthor, timestamp) values ('{0}','{1}','{2}','{3}')";
            query = String.Format(query, new_page.GetPagetitle(), new_page.GetPagebody(), new_page.GetPageauthor(), new_page.GetTimeStamp().ToString("yyyy-MM-dd"));

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //We create debugs so that if something goes wrong we know on what part it was
                Debug.WriteLine("Something went wrong in the AddPage Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }
        // We create another method for when a user wants to view a page that is already in the database.
        public HTTP_Page FindPage(int id)
        {
            
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
           
            HTTP_Page result_page = new HTTP_Page();

            
            try
            {
                //Again we write a query specific to finding pages depending on the id number by connecting it to the database
                string query = "select * from pagesmgmt where pageid =" +id;

                Debug.WriteLine("Connection Initialized...");
               
                Connect.Open();
               
                MySqlCommand cmd = new MySqlCommand(query, Connect);
             
                MySqlDataReader resultset = cmd.ExecuteReader();


                List<HTTP_Page> pages = new List<HTTP_Page>();

                while (resultset.Read())
                {
                   
                    HTTP_Page currentpage = new HTTP_Page();

                   
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        string key = resultset.GetName(i);
                        string value = resultset.GetString(i);
                        Debug.WriteLine("Attempting to transfer " + key + " data of " + value);
                        // We make sure to write the correct variables so that the information matches
                        switch (key)
                        {
                        
                            case "pagetitle":
                                currentpage.SetPagetitle(value);
                                break;
                            case "pagebody":
                                currentpage.SetPagebody(value);
                                break;
                            case "pageauthor":
                                currentpage.SetPageauthor(value);
                                break;
                            case "timestamp":
                                currentpage.SetTimeStamp(DateTime.Parse(value));
                                //we have to get the time that the databas automatically created
                                break;
                        }

                    }
                   
                    pages.Add(currentpage);
                }

                result_page = pages[0]; 

            }
            catch (Exception ex)
            {
                //We create debugs so that if something goes wrong we know on what part it was
                Debug.WriteLine("Something went wrong in the find Page method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return result_page;
        }
        public void EditPage(int pageid, HTTP_Page new_page)
        {
            
            string query = "update pagesmgmt set pagetitle='{0}', pagebody='{1}', pageauthor='{2}' where pageid={3}";
            query = String.Format(query, new_page.GetPagetitle(), new_page.GetPagebody(), new_page.GetPageauthor(), pageid);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + query);
            }
            catch (Exception ex)
            {
                //We create debugs so that if something goes wrong we know on what part it was
                Debug.WriteLine("Something went wrong in the EditPage method");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }
        //We create the DeletePage method so that we can reference it where we want the method to apply
        public void DeletePage(int pageid)
        {
            //Write the query that does the delete operation
            string removepage = "delete from pagesmgmt where pageid = {0}";
            removepage = String.Format(removepage, pageid);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            
            MySqlCommand cmd_removepage = new MySqlCommand(removepage, Connect);
            try
            {
              
                Connect.Open();
                
                cmd_removepage.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + cmd_removepage);
            }
            catch (Exception ex)
            {
                //We create debugs so that if something goes wrong we know on what part it was
                Debug.WriteLine("Something went wrong in the delete page method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }
    }
   
}