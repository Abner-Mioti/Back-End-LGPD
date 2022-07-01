namespace LGPD_MDE.Entities.Generated
{
    public class QuestionCategory
    {
        public int Id { get; set; }
        public string Category { get; set; }

        public virtual ICollection<Question> Question { get; set; }

    }
}
