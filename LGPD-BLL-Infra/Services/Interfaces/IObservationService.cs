using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;

namespace LGPD_BLL_Infra.Services.Interfaces
{
    public interface IObservationService
    {
        Task Register(ObservationDTO observation);

        Task<IEnumerable<GetObservationDTO>> GetAll();

        Task<GetObservationDTO> GetById(int id);

        Task Delete(int id);

        Task Update(UpdateObservationDTO observation);

    }
}
