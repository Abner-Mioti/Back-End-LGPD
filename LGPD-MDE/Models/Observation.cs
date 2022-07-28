namespace LGPD_MDE.Models
{
    public class Observation
    {
        public int id { get; set; }
        public string observation { get; set; }
        public Question question { get; set; }
    }
}
