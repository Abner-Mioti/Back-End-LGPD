using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;

namespace LGPD_BLL_Infra.Services.Interfaces
{
    public interface IProbabilityService
    {
        Task Register(ProbabilityDTO enterprise);

        Task<IEnumerable<GetProbabilityDTO>> GetAll();

        Task<GetProbabilityDTO> GetById(int id);

        Task Delete(int id);

        Task Update(UpdateProbabilityDTO enteprise);

    }
}
