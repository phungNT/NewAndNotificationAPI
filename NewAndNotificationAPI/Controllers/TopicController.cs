using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NewAndNotificationAPI.Data;
using NewAndNotificationAPI.Models;

namespace NewAndNotificationAPI.Controller{

    [Route("api/topics")]
    [ApiController]
    public class TopicController:ControllerBase{
        private readonly ITopicRepo _repository;
        private readonly IMapper _mapper;

        public TopicController(ITopicRepo repository, IMapper mapper){
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <List<Topic>> GetAllTopic(){
            var topicItems = _repository.GetAllTopics();
            if(topicItems!=null){
                return Ok(topicItems);
            }
            return NotFound();
        }

        //Get api/topics/{topicId}
        [HttpGet("{topicId}", Name="GetTopicById")]
        public ActionResult <Topic> GetTopicById(int topicId){
            var topicItem = _repository.GetTopicById(topicId);
            if(topicItem!=null){
                return Ok(topicItem);
            }
            return NotFound();
        }
        
    }
}