using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;

namespace LGPD_BLL_Infra.Services.Interfaces
{
    public interface IReportPeriodService
    {
        Task<IEnumerable<GetReportPeriodDTO>> GetAll();
        Task Register(ReportPeriodDTO dto);
        Task Update(UpdateReportPeriodDTO reportPeriod);
        Task Delete(int id);
        Task<GetReportPeriodDTO> GetById(int id);

    }
}
