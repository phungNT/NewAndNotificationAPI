using System.ComponentModel.DataAnnotations;

namespace NewAndNotificationAPI.Models{
    public class Tag{
     
     
        [Key]
        public int tagId { get;  set; }
        [Required]    
        public string name { get;  set; }
        [Required]
        public string status { get;  set; }
        [Required]
        public string description { get;  set; }

        [Required]
        public int topicId { get;  set; }
        [Required]
        public virtual Topic topic {get;set;}
    }
}