using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;

namespace LGPD_BLL_Infra.Services.Interfaces
{
    public interface IStepService
    {
        Task<IEnumerable<GetStepDTO>> GetAll();
        Task Register(StepDTO dto);
        Task Update(UpdateStepDTO step);
        Task Delete(int id);
        Task<GetStepDTO> GetById(int id);

    }
}
