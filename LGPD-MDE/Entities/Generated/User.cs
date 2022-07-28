namespace LGPD_MDE.Entities.Generated
{
    public class User
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int AreaId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public string Mobile { get; set; }
        public string Users { get; set; }
        public string Password { get; set; }
        public string OAB { get; set; }
        public bool IsActive { get; set; }

        public virtual Company Company { get; set; }
        public virtual Area Area { get; set; }

    }
}
