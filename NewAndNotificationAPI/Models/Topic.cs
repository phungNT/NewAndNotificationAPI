using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NewAndNotificationAPI.Models{
    public class Topic{

        [Key]
        public int topicId { get;  set; }
        [Required]
        public string name { get;  set; }
        [Required]
        public string status { get;  set; }
        [Required]
        public string description { get;  set; }

        public virtual List<Tag> tags{get;set;}
       
         public virtual List<StudentTopic> StudentTopic{get;set;}
    }
}