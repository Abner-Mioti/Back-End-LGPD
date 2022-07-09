using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_BLL.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _repositoryEnterprise;
        private readonly IMapper _mapper;

        public CompanyService(ICompanyRepository repositoryEnterprise,
            IMapper mapper)
        {
            _repositoryEnterprise = repositoryEnterprise;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetCompanyDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Company>, IEnumerable<GetCompanyDTO>>(await _repositoryEnterprise.GetAll());

        }

        public async Task<GetCompanyDTO> GetById(int id)
        {
            var enterprise = _mapper.Map<Company, GetCompanyDTO>(await _repositoryEnterprise.GetById(id));

            if (enterprise == null)
                throw new ArgumentException("Enterprise Não Existe");

            return enterprise;
        }

        public async Task Register(CompanyDTO enterprise)
        {
            var entidade = _mapper.Map<CompanyDTO, Company>(enterprise);

            await _repositoryEnterprise.Add(entidade);
        }

        public async Task Update(UpdateCompanyDTO enteprise)
        {
            var entepriseDB = await _repositoryEnterprise.GetById(enteprise.Id);

            if (entepriseDB == null)
            {
                throw new ArgumentException("Workshop Não Existe");
            }

            entepriseDB.QuestionId = enteprise.QuestionId;
            entepriseDB.FieldId = enteprise.FieldId;
            entepriseDB.CompanyCategoryId = enteprise.CompanyCategoryId;
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

            await _repositoryEnterprise.Update(entepriseDB);
        }

        public async Task Delete(int id)
        {
            var enterpriseDB = await _repositoryEnterprise.GetById(id);

            if (enterpriseDB == null)
            {
                throw new ArgumentException("Enterprise Não Existe");
            }

            await _repositoryEnterprise.Remove(enterpriseDB);

        }
    }
}
