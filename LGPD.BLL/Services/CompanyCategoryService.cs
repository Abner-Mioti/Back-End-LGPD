using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_BLL.Services
{
    public class CompanyCategoryService : ICompanyCategoryService
    {
        private readonly ICompanyCategoryRepository _repositoryEnterpriseCategory;
        private readonly IMapper _mapper;

        public CompanyCategoryService(ICompanyCategoryRepository repositoryEnterpriseCategory,
            IMapper mapper)
        {
            _repositoryEnterpriseCategory = repositoryEnterpriseCategory;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetCompanyCategoryDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<CompanyCategory>, IEnumerable<GetCompanyCategoryDTO>>(await _repositoryEnterpriseCategory.GetAll());

        }
        public async Task<GetCompanyCategoryDTO> GetById(int id)
        {
            var enterprise = _mapper.Map<CompanyCategory, GetCompanyCategoryDTO>(await _repositoryEnterpriseCategory.GetById(id));

            if (enterprise == null)
                throw new ArgumentException("Enterprise Category Não Existe");

            return enterprise;
        }
        public async Task Register(CompanyCategoryDTO dto)
        {

            var entidade = _mapper.Map<CompanyCategoryDTO, CompanyCategory>(dto);

            await _repositoryEnterpriseCategory.Add(entidade);
        }

        public async Task Update(UpdateCompanyCategoryDTO enterpriseCategory)
        {
            var enterpriseCategoryDB = await _repositoryEnterpriseCategory.GetById(enterpriseCategory.Id);

            if (enterpriseCategoryDB == null)
            {
                throw new ArgumentException("Enterprise Category  Não Existe");
            }

            enterpriseCategoryDB.Category = enterpriseCategory.Category;

            await _repositoryEnterpriseCategory.Update(enterpriseCategoryDB);
        }

        public async Task Delete(int id)
        {
            var enterpriseCategoryDB = await _repositoryEnterpriseCategory.GetById(id);

            if (enterpriseCategoryDB == null)
            {
                throw new ArgumentException("Enterprise Category Não Existe");
            }

            await _repositoryEnterpriseCategory.Remove(enterpriseCategoryDB);

        }


    }
}
