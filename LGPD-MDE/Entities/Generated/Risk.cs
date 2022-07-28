namespace LGPD_MDE.Entities.Generated
{
    public class Risk
    {
        public int Id { get; set; }
        public string Risks { get; set; }

        public virtual ICollection<Question> Question { get; set; }
    }
}
