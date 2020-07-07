using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace NewAndNotificationAPI.Models{
    public class Student{

        [Key]
        public int studentId {get;set;}
        public string fullName {get;set;}
        public string password {get;set;}
        public string email {get;set;}
        public string major {get;set;}
        public string className {get;set;}
        public string curriculum {get;set;}
        public string address {get;set;}

        [MaxLength(9)]
        public int phoneNumber {get;set;}
        public string status {get;set;}

        public string gender {get;set;}
        public DateTime dateOfBirth {get;set;}

        public virtual List<StudentTopic> StudentTopic{get;set;}
    }
}