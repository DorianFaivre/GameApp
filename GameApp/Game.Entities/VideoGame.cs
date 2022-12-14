using System.Xml.Schema;

namespace Game.Entities
{
    public class VideoGame
    {
        public int Id { get; set; }
        public String name { get; set; }

        public String description { get; set; }

        public String author { get; set; }

        public String picture { get; set; }

        public List<String> plateform { get; set; }

        public int price { get; set; }

        public DateTime date { get; set; }

        public List<double> grade {get;set;}

        public List<Comment> commentList { get; set; } 

    }
}