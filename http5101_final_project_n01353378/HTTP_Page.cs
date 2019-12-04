using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace http5101_final_project_n01353378
{
    public class HTTP_Page
    {

        
        private string Pagetitle;
        private string Pagebody;
        private string Pageauthor;
        private DateTime TimeStamp;

        // We create a class which has all the information which is part of each page created

        //we use methods that return the value inside this strings
        public string GetPagetitle()
        {
            return Pagetitle;
        }
        public string GetPagebody()
        {
            return Pagebody;
        }
        public string GetPageauthor()
        {
            return Pageauthor;
        }
        public DateTime GetTimeStamp()
        {
            return TimeStamp;
        }

        //we use methods to set information into the value
        public void SetPagetitle(string value)
        {
            Pagetitle = value;
        }
        public void SetPagebody(string value)
        {
            Pagebody = value;
        }
        public void SetPageauthor(string value)
        {
            Pageauthor = value;
        }
        public void SetTimeStamp(DateTime value)
        {
            TimeStamp = value;
        }
    }
}