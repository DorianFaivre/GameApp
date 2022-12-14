using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;
using Game.BL.Contracts;
using Game.DAL;

namespace Game.BL
{
    public class CommentService : ICommentService
    {
        private Context _commentContext;

        public CommentService(Context context)
        {
            _commentContext = context;
        }

        public Comment Create(Comment comment)
        {
            var entity = _commentContext.Comment.Add(comment);
            _commentContext.SaveChanges();
            return entity.Entity;
        }

        public Comment Get(int id)
        {
            //var getComment = _commentContext.Comment.Find(id);
            var getComment = _commentContext.Comment.FirstOrDefault(x => x.Id == id);
            if (getComment == null) 
            { 
                throw new NotImplementedException(); 
            }
            else
            {
                return getComment;
            }
        }


        public List<Comment> GetAll()
        {
            return _commentContext
                .Comment
                .ToList();
        }


        public Comment Update(Comment updateComment)
        {
            var entity = _commentContext.Comment.Update(updateComment);
            _commentContext.SaveChanges();
            //var commentChanged = this.Get(updateComment.Id);
            return entity.Entity;
        }

        public void Delete(int id)
        {
            Comment comment = Get(id);
            var entity = _commentContext.Comment.Remove(comment);
            _commentContext.SaveChanges();
        }
    }
}
