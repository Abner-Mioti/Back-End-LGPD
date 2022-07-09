using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;

namespace LGPD_BLL_Infra.Services.Interfaces
{
    public interface IRiskService
    {
        Task<IEnumerable<GetRiskDTO>> GetAll();
        Task Register(RiskDTO dto);
        Task Update(UpdateRiskDTO reportQuestion);
        Task Delete(int id);
        Task<GetRiskDTO> GetById(int id);

    }
}
