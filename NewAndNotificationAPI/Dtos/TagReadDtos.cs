using System.ComponentModel.DataAnnotations;

namespace NewAndNotificationAPI.Dtos{
    public class TagReadDtos{
     
     
        public int tagId { get;  set; }
        public string name { get;  set; }
        public string status { get;  set; }
        public string description { get;  set; }

      
    }
}