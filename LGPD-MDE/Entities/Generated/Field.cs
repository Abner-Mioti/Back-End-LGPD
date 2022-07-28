namespace LGPD_MDE.Entities.Generated
{
    public class Field
    {
        public int Id { get; set; }
        public string Fields { get; set; }

        public virtual ICollection<Company> Company { get; set; }

    }
}
