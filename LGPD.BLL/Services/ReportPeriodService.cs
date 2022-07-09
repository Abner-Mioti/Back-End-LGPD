using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_BLL.Services
{
    public class ReportPeriodService : IReportPeriodService
    {
        private readonly IReportPeriodRepository _repositoryReportPeriod;
        private readonly IMapper _mapper;

        public ReportPeriodService(IReportPeriodRepository repositoryReportPeriod,
            IMapper mapper)
        {
            _repositoryReportPeriod = repositoryReportPeriod;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetReportPeriodDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<ReportPeriod>, IEnumerable<GetReportPeriodDTO>>(await _repositoryReportPeriod.GetAll());

        }
        public async Task<GetReportPeriodDTO> GetById(int id)
        {
            var report = _mapper.Map<ReportPeriod, GetReportPeriodDTO>(await _repositoryReportPeriod.GetById(id));

            if (report == null)
                throw new ArgumentException("Report Period Não Existe");

            return report;
        }
        public async Task Register(ReportPeriodDTO dto)
        {

            var entidade = _mapper.Map<ReportPeriodDTO, ReportPeriod>(dto);

            await _repositoryReportPeriod.Add(entidade);
        }

        public async Task Update(UpdateReportPeriodDTO reportPerid)
        {
            var reportPeridDB = await _repositoryReportPeriod.GetById(reportPerid.Id);

            if (reportPeridDB == null)
            {
                throw new ArgumentException("Report Period Não Existe");
            }

            reportPeridDB.Period = reportPerid.Period;

            await _repositoryReportPeriod.Update(reportPeridDB);
        }

        public async Task Delete(int id)
        {
            var reportPeridDB = await _repositoryReportPeriod.GetById(id);

            if (reportPeridDB == null)
            {
                throw new ArgumentException("Report Period Não Existe");
            }

            await _repositoryReportPeriod.Remove(reportPeridDB);

        }

    }
}
