using System.Collections.Generic;
using NewAndNotificationAPI.Models;

namespace NewAndNotificationAPI.Data{
    public interface ITopicRepo
    {
        bool SaveChanges();

        List<Topic> GetAllTopics();
        Topic GetTopicById(int id);
        void CreateTopic(Topic topic);
        void UpdateTopic(Topic topic);
        void DeleteTopic(Topic topic); 

       // List<Topic> GetListTopicByStudentId(int studentId);
    } 
}