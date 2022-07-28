namespace LGPD_MDE.Dto.GetDTO
{
    public class GetUserDTO
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int AreaId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public string Mobile { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string OAB { get; set; }
        public bool IsActive { get; set; }
    }
}
