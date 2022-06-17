namespace LGPD_MDE.Models
{
    public class Enterprise
    {
        public int id { get; set; }
        public string cnpj { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string site { get; set; }
        public Field field { get; set; }
        public EnterpriseCategory category { get; set; }
        public float progress { get; set; }
        public bool progrectionStatus { get; set; }
        public DateTime progrectionStartDate { get; set; }
        public float maturity { get; set; }
        public DateTime registrationDate { get; set; }
        public ReportPeriod reportPeriod { get; set; }
        public DateTime maturityDate { get; set; }
        public Workshop workshop { get; set; }
    }
}
