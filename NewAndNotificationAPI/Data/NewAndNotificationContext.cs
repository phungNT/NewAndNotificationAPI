using Microsoft.EntityFrameworkCore;
using NewAndNotificationAPI.Models;

namespace NewAndNotificationAPI.Data{
    public class NewAndNotificationContext:DbContext{
        public NewAndNotificationContext(DbContextOptions<NewAndNotificationContext> opt):base(opt){

        }
        public DbSet<Topic> Topics{get;set;}
         public DbSet<Tag> Tags{get;set;}

         public DbSet<Student> Students{get;set;}
         public DbSet<StudentTopic> StudentTopics{get;set;}

         protected override void OnModelCreating(ModelBuilder modelBuilder){
             base.OnModelCreating(modelBuilder);
             modelBuilder.Entity<Tag>()
             .HasOne<Topic>(tg => tg.topic)
             .WithMany(t => t.tags );
            // .HasForeignKey(tg => tg.topicId);


            //Student - Topic
            modelBuilder.Entity<StudentTopic>()
            .HasKey(st=>new {st.studentId, st.topicId});

            modelBuilder.Entity<StudentTopic>()
            .HasOne(st => st.student)
            .WithMany(s=>s.StudentTopic)
            .HasForeignKey(st => st.studentId);
            
            modelBuilder.Entity<StudentTopic>()
            .HasOne(st => st.topic)
            .WithMany(t => t.StudentTopic)
            .HasForeignKey(st => st.topicId);
         }

    }
}