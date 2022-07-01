namespace LGPD_MDE.Entities.Generated
{
    public class Probability
    {
        public int Id { get; set; }
        public string Probabilitys { get; set; }

        public virtual ICollection<Question> Question { get; set; }



    }
}
