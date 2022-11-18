using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Game.Entities;

namespace Game.BL.Contracts
{
    public interface ICommentService
    {
        public List<Comment> GetAll();
        public Comment Create(Comment comment);

        public Comment Get(int id);

        public Comment Delete(int id);

        public Comment Update(int id, Comment updateComment);
    }
}

