using System.Collections.Generic;
using System.Linq;
using NewAndNotificationAPI.Models;

namespace NewAndNotificationAPI.Data{
    public class SqlTagRepo : ITagRepo
    {
        private NewAndNotificationContext _context;

       public SqlTagRepo (NewAndNotificationContext context){
           _context = context;
       }
       
        public void CreateTag(Tag tag)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteTag(Tag tag)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Tag> GetAllTags()
        {
            return  _context.Tags.ToList();
            

        }

        public Tag GetTagById(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateTag(Tag tag)
        {
            throw new System.NotImplementedException();
        }
    }
}