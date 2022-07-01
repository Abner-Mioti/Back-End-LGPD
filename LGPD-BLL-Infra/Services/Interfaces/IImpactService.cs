using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;

namespace LGPD_BLL_Infra.Services.Interfaces
{
    public interface IImpactService
    {
        Task<IEnumerable<GetImpactDTO>> GetAll();
        Task Register(ImpactDTO dto);
        Task Update(UpdateImpactDTO field);
        Task Delete(int id);
        Task<GetImpactDTO> GetById(int id);


    }
}
