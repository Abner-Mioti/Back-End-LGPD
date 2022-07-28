namespace LGPD_MDE.Entities.Generated
{
    public class Observation
    {
        public int Id { get; set; }
        public string Observations { get; set; }
        public virtual ICollection<Question> Question { get; set; }

    }
}
