using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_BLL.Services
{
    public class EnterpriseService : IEnterpriseService
    {
        private readonly IEnterpriseRepository _repositoryEnterprise;
        private readonly IMapper _mapper;

        public EnterpriseService(IEnterpriseRepository repositoryEnterprise,
            IMapper mapper)
        {
            _repositoryEnterprise = repositoryEnterprise;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetEnterpriseDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Enterprise>, IEnumerable<GetEnterpriseDTO>>(await _repositoryEnterprise.GetAll());

        }

        public async Task<GetEnterpriseDTO> GetById(int id)
        {
            var enterprise = _mapper.Map<Enterprise, GetEnterpriseDTO>(await _repositoryEnterprise.ObterPorId(id));

            if (enterprise == null)
                throw new ArgumentException("Enterprise Não Existe");

            return enterprise;
        }

        public async Task Register(EnterpriseDTO enterprise)
        {
            var entidade = _mapper.Map<EnterpriseDTO, Enterprise>(enterprise);

            await _repositoryEnterprise.Adicionar(entidade);
        }

        public async Task Update(UpdateEnterpriseDTO enteprise)
        {
            var entepriseDB = await _repositoryEnterprise.ObterPorId(enteprise.Id);

            if (entepriseDB == null)
            {
                throw new ArgumentException("Workshop Não Existe");
            }

            entepriseDB.QuestionId = enteprise.QuestionId;
            entepriseDB.FieldId = enteprise.FieldId;
            entepriseDB.EnterpriseCategoryId = enteprise.EnterpriseCategoryId;
            entepriseDB.ReportPeriodId = enteprise.ReportPeriodId;
            entepriseDB.WorkshopId = enteprise.WorkshopId;
            entepriseDB.CNPJ = enteprise.CNPJ;
            entepriseDB.Name = enteprise.Name;
            entepriseDB.Email = enteprise.Email;
            entepriseDB.Mobile = enteprise.Mobile;
            entepriseDB.Site = enteprise.Site;
            entepriseDB.Progress = enteprise.Progress;
            entepriseDB.ProgrectionStatus = enteprise.ProgrectionStatus;
            entepriseDB.ProgrectionStartDate = enteprise.ProgrectionStartDate;
            entepriseDB.Maturity = enteprise.Maturity;
            entepriseDB.RegistrationDate = enteprise.RegistrationDate;
            entepriseDB.MaturityDate = enteprise.MaturityDate;

            await _repositoryEnterprise.Atualizar(entepriseDB);
        }

        public async Task Delete(int id)
        {
            var enterpriseDB = await _repositoryEnterprise.ObterPorId(id);

            if (enterpriseDB == null)
            {
                throw new ArgumentException("Enterprise Não Existe");
            }

            await _repositoryEnterprise.Remover(enterpriseDB);

        }
    }
}
