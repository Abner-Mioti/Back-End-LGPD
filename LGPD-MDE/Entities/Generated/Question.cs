namespace LGPD_MDE.Entities.Generated
{
    public class Question
    {
        public int Id { get; set; }
        public int AreaId { get; set; }
        public int ObservationId { get; set; }
        public int RiskId { get; set; }
        public int QuestionCategoryId { get; set; }
        public int ImpactId { get; set; }
        public int ProbabilityId { get; set; }
        public string Wording { get; set; }
        public int Reply { get; set; }
        public bool RepliedStatus { get; set; }
        public bool SuitableStatus { get; set; }
        public string Effect { get; set; }
        public string Action { get; set; }

        public virtual Area Area { get; set; }
        public virtual QuestionCategory QuestionCategory { get; set; }
        public virtual Impact Impact { get; set; }
        public virtual Probability Probability { get; set; }
        public virtual Observation Observation { get; set; }
        public virtual Risk Risk { get; set; }
        public virtual ICollection<Company> Company { get; set; }





    }
}
