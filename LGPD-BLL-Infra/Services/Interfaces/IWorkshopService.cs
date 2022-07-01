using LGPD_MDE.Dto;
using LGPD_MDE.Dto.AtualizarDTO;
using LGPD_MDE.Dto.Get;

namespace LGPD_BLL_Infra.Services.Interfaces
{
    public interface IWorkshopService
    {
        Task<IEnumerable<GetWorkshopDTO>> GetAll();
        Task Register(WorkshopDTO dto);
        Task Update(UpdateWorkshopDTO workshop);
        Task Delete(int id);
        Task<GetWorkshopDTO> GetById(int id);
    }
}
