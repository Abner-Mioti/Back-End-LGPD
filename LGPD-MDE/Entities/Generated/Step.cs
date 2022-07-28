namespace LGPD_MDE.Entities.Generated
{
    public class Step
    {
        public int Id { get; set; }
        public string Steps { get; set; }
        public int Value { get; set; }
        public DateTime CloseDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Itens { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Company> Company { get; set; }

    }
}
