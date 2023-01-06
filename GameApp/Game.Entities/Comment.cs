using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string author { get; set; }

        public string comment { get; set; }

        public DateTime date { get; set; }

        public double grade { get; set; }
    }
}
