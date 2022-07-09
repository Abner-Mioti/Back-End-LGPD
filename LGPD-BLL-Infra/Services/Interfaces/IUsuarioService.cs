using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;

namespace LGPD_BLL_Infra.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<IEnumerable<GetUsuarioDTO>> GetAll();
        Task Register(UsuarioDTO dto);
        Task Update(UpdateUsuarioDTO workshop);
        Task Delete(int id);
        Task<GetUsuarioDTO> GetById(int id);

    }
}
