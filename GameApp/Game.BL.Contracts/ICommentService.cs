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

        public void Delete(int id);

        public Comment Update(Comment updateComment);
    }
}

