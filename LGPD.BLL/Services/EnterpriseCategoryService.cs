using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_BLL.Services
{
    public class EnterpriseCategoryService : IEnterpriseCategoryService
    {
        private readonly IEnterpriseCategoryRepository _repositoryEnterpriseCategory;
        private readonly IMapper _mapper;

        public EnterpriseCategoryService(IEnterpriseCategoryRepository repositoryEnterpriseCategory,
            IMapper mapper)
        {
            _repositoryEnterpriseCategory = repositoryEnterpriseCategory;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetEnterpriseCategoryDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<EnterpriseCategory>, IEnumerable<GetEnterpriseCategoryDTO>>(await _repositoryEnterpriseCategory.GetAll());

        }
        public async Task<GetEnterpriseCategoryDTO> GetById(int id)
        {
            var enterprise = _mapper.Map<EnterpriseCategory, GetEnterpriseCategoryDTO>(await _repositoryEnterpriseCategory.ObterPorId(id));

            if (enterprise == null)
                throw new ArgumentException("Enterprise Category Não Existe");

            return enterprise;
        }
        public async Task Register(EnterpriseCategoryDTO dto)
        {

            var entidade = _mapper.Map<EnterpriseCategoryDTO, EnterpriseCategory>(dto);

            await _repositoryEnterpriseCategory.Adicionar(entidade);
        }

        public async Task Update(UpdateEnterpriseCategoryDTO enterpriseCategory)
        {
            var enterpriseCategoryDB = await _repositoryEnterpriseCategory.ObterPorId(enterpriseCategory.Id);

            if (enterpriseCategoryDB == null)
            {
                throw new ArgumentException("Enterprise Category  Não Existe");
            }

            enterpriseCategoryDB.Category = enterpriseCategory.Category;

            await _repositoryEnterpriseCategory.Atualizar(enterpriseCategoryDB);
        }

        public async Task Delete(int id)
        {
            var enterpriseCategoryDB = await _repositoryEnterpriseCategory.ObterPorId(id);

            if (enterpriseCategoryDB == null)
            {
                throw new ArgumentException("Enterprise Category Não Existe");
            }

            await _repositoryEnterpriseCategory.Remover(enterpriseCategoryDB);

        }


    }
}
