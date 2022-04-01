using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Status
    {

        public Status(string title,string content)
        {
            Title = title;
            Content = content;
        }
        public string Title { get; set; }
        public string Content { get; set; }
         public  DateTime sharedDate { get; set; }
    }
}
