using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;

namespace LGPD_BLL_Infra.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<GetUserDTO>> GetAll();
        Task Register(UserDTO dto);
        Task Update(UpdateUserDTO workshop);
        Task Delete(int id);
        Task<GetUserDTO> GetById(int id);

    }
}
