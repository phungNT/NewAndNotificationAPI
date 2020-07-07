using System.Collections.Generic;
using NewAndNotificationAPI.Models;

namespace NewAndNotificationAPI.Data{
    public interface ITagRepo
    {
        
        bool SaveChanges();

        IEnumerable<Tag> GetAllTags();
        Tag GetTagById(int id);
        void CreateTag(Tag tag);
        void UpdateTag(Tag tag);
        void DeleteTag(Tag tag); 
    }
}