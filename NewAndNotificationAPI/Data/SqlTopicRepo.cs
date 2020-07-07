using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NewAndNotificationAPI.Models;

namespace NewAndNotificationAPI.Data{
    public class SqlTopicRepo : ITopicRepo
    {
       private NewAndNotificationContext _context;
        private readonly IMapper _mapper;
       public SqlTopicRepo (NewAndNotificationContext context, IMapper mapper){
           _context = context;
           _mapper = mapper;
       }
       
        public void CreateTopic(Topic topic)
        {
           if(topic == null){
               throw new ArgumentNullException(nameof(topic));
           }
           _context.Add(topic);
        }

        public void DeleteTopic(Topic topic)
        {
            throw new System.NotImplementedException();
        }

        public List<Topic> GetAllTopics()
        {
           List<Topic> listTopic=_context.Topics.Include("tags").ToList();
           if(listTopic!=null){
                for(int i = 0; i< listTopic.Count -1; i++){
                    if( listTopic.ElementAt(i).tags.Count > 0){
                        for(int j = 0; j < listTopic.ElementAt(i).tags.Count; j++ ){
                            listTopic.ElementAt(i).tags.ElementAt(j).topic = null;
                    }
               }
              
           }
           }
           
            return listTopic;
            
        }

        public Topic GetTopicById(int id)
        {
             Topic topic = _context.Topics.Include("tags").ToList().FirstOrDefault(p => p.topicId==id);
             if(topic!=null){
                if(topic.tags.Count >0){
                    for(int i =0; i< topic.tags.Count ; i++){
                        topic.tags.ElementAt(i).topic = null;
                    }
                }
             }
            
            return topic;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >=0);
        }

        public void UpdateTopic(Topic topic)
        {
            throw new System.NotImplementedException();
        }

        // public List<Topic> GetListTopicByStudentId(int studentIdagr)
        // {
        //     //  List<Topic> listTopic =  (from topic in Topic 
        //     //                             from student in topic.S

        //     //  return listTopic;
        // }
    }
}