using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_BLL.Services
{
    public class ImpactService : IImpactService
    {
        private readonly IImpactRepository _repositoryImpact;
        private readonly IMapper _mapper;

        public ImpactService(IImpactRepository repositoryImpact,
            IMapper mapper)
        {
            _repositoryImpact = repositoryImpact;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetImpactDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Impact>, IEnumerable<GetImpactDTO>>(await _repositoryImpact.GetAll());

        }
        public async Task<GetImpactDTO> GetById(int id)
        {
            var impact = _mapper.Map<Impact, GetImpactDTO>(await _repositoryImpact.ObterPorId(id));

            if (impact == null)
                throw new ArgumentException("Impact Não Existe");

            return impact;
        }
        public async Task Register(ImpactDTO dto)
        {

            var entidade = _mapper.Map<ImpactDTO, Impact>(dto);

            await _repositoryImpact.Adicionar(entidade);
        }

        public async Task Update(UpdateImpactDTO impact)
        {
            var impactDB = await _repositoryImpact.ObterPorId(impact.Id);

            if (impactDB == null)
            {
                throw new ArgumentException("Impact Não Existe");
            }

            impactDB.Impacts = impact.Impacts;

            await _repositoryImpact.Atualizar(impactDB);
        }

        public async Task Delete(int id)
        {
            var impactDB = await _repositoryImpact.ObterPorId(id);

            if (impactDB == null)
            {
                throw new ArgumentException("Impact Não Existe");
            }

            await _repositoryImpact.Remover(impactDB);

        }

    }
}
