namespace LGPD_MDE.Models
{
    public class Question
    {
        public int id { get; set; }
        public string wording { get; set; }
        public int reply { get; set; }
        public bool repliedStatus { get; set; }
        public bool suitableStatus { get; set; }
        public Area area { get; set; }
        public QuestionCategory category { get; set; }
        public Impact impact { get; set; }
        public string effect { get; set; }
        public string action { get; set; }
        public Probability probability { get; set; }
        public Enterprise enterprise { get; set; }
    }
}
