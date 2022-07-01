namespace LGPD_MDE.Entities.Generated
{
    public class Entity
    {
        public int Id { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; } = DateTime.Now;

    }
}
