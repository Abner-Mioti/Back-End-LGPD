namespace LGPD_MDE.Dto
{
    public class QuestionDTO
    {
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
    }
}
