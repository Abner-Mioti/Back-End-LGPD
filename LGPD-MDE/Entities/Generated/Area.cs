namespace LGPD_MDE.Entities.Generated
{
    public class Area
    {
        public int Id { get; set; }
        public string Areas { get; set; }

        public virtual ICollection<Question> Question { get; set; }
        public virtual ICollection<User> User { get; set; }

    }
}
