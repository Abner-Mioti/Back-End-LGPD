namespace LGPD_MDE.Entities.Generated
{
    public class CompanyCategory
    {
        public int Id { get; set; }
        public string Category { get; set; }

        public virtual ICollection<Company> Company { get; set; }

    }
}
