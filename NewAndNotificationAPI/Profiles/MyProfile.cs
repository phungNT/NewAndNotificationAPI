using AutoMapper;
using NewAndNotificationAPI.Dtos;
using NewAndNotificationAPI.Models;

namespace MyProfile.Profiles{
    public class MyProfile:Profile{
        public MyProfile(){
            
            //Source -> Target
            CreateMap<Tag, TagReadDtos>();
        }
    }
}