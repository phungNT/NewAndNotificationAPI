using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NewAndNotificationAPI.Data;
using NewAndNotificationAPI.Models;

namespace NewAndNotificationAPI.Controller{

    [Route("api/tags")]
    [ApiController]
    public class TagController:ControllerBase{
        private readonly ITagRepo _repository;
        private readonly IMapper _mapper;

        public TagController(ITagRepo repository, IMapper mapper){
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<Tag>> GetAllTag(){
            var tagItems = _repository.GetAllTags();
            if(tagItems!=null){
                return Ok(tagItems);
            }
            return NotFound();
        }
        
    }
}