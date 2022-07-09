namespace LGPD_MDE.Dto.UpdateDTO
{
    public class UpdateUsuarioDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public string Mobile { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
