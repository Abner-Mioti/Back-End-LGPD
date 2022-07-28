namespace LGPD_MDE.Entities.Generated
{
    public class Workshop
    {
        public int Id { get; set; }
        public string MeetingLink { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<Company> Company { get; set; }

    }
}
