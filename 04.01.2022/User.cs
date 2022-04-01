using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class User
    {
        List<Status> statuses = new List<Status>();
        public string Username { get; set; }
        public void ShareStatus(Status status)
        {
            statuses.Add(status);
        }
        public string GetStatusByTitle(string title)
        {
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            foreach (var item in statuses)
            {
                if (item.Title ==title)
                {
                    return $"title :{item.Title} Content : {item.Content} - shared {dateTime.Second - item.sharedDate.Second} seconds ago";
                }
                throw new NotFoundException("Yoxdur");
                
            }
            return null;
        }



    }
}
