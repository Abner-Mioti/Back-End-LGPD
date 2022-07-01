namespace LGPD_MDE.Entities.Generated
{
    public class ReportPeriod
    {
        public int Id { get; set; }
        public string Period { get; set; }
        public virtual ICollection<Enterprise> Enterprise { get; set; }
    }
}
