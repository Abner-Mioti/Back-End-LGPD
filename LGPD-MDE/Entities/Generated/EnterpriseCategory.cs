namespace LGPD_MDE.Entities.Generated
{
    public class EnterpriseCategory
    {
        public int Id { get; set; }
        public string Category { get; set; }

        public virtual ICollection<Enterprise> Enterprise { get; set; }

    }
}
