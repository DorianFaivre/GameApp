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

        public String plateform { get; set; }

        public int price { get; set; }

        public DateTime date { get; set; }

        public List<int> grade {get;set;}

        public int averageGrade(List<int> grade)
        {
            return 0;
        }
    }
}