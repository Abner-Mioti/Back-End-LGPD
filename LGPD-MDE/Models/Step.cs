namespace LGPD_MDE.Models
{
    public class Step
    {
        public int id { get; set; }
        public string step { get; set; }
        public int value { get; set; }
        public DateTime closeDate { get; set; }
        public DateTime endDate { get; set; }
        public int itens { get; set; }
        public bool active { get; set; }
        public Enterprise enterprise { get; set; }
    }
}
