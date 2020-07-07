namespace NewAndNotificationAPI.Models{
    public class StudentTopic{
        public int id {get;set;}
        public int studentId {get;set;}
        public Student student {get;set;}
        public int topicId {get;set;}
        public Topic topic {get;set;}
        public string description {get;set;}

    }
}