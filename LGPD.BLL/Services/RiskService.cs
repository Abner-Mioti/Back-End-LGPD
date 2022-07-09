using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_BLL.Services
{
    public class RiskService : IRiskService
    {
        private readonly IRiskRepository _repositoryRisk;
        private readonly IMapper _mapper;

        public RiskService(IRiskRepository repositoryRisk,
            IMapper mapper)
        {
            _repositoryRisk = repositoryRisk;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetRiskDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Risk>, IEnumerable<GetRiskDTO>>(await _repositoryRisk.GetAll());

        }
        public async Task<GetRiskDTO> GetById(int id)
        {
            var report = _mapper.Map<Risk, GetRiskDTO>(await _repositoryRisk.GetById(id));

            if (report == null)
                throw new ArgumentException("Risk Não Existe");

            return report;
        }
        public async Task Register(RiskDTO dto)
        {

            var entidade = _mapper.Map<RiskDTO, Risk>(dto);

            await _repositoryRisk.Add(entidade);
        }

        public async Task Update(UpdateRiskDTO reportRisk)
        {
            var reportRiskDB = await _repositoryRisk.GetById(reportRisk.Id);

            if (reportRiskDB == null)
            {
                throw new ArgumentException("Risk Não Existe");
            }

            reportRiskDB.Risks = reportRisk.Risks;

            await _repositoryRisk.Update(reportRiskDB);
        }

        public async Task Delete(int id)
        {
            var reportRiskDB = await _repositoryRisk.GetById(id);

            if (reportRiskDB == null)
            {
                throw new ArgumentException("Risk Não Existe");
            }

            await _repositoryRisk.Remove(reportRiskDB);

        }

    }
}
