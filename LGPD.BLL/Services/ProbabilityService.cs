using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_BLL.Services
{
    public class ProbabilityService : IProbabilityService
    {
        private readonly IProbabilityRepository _repositoryProbability;
        private readonly IMapper _mapper;

        public ProbabilityService(IProbabilityRepository repositoryProbability,
            IMapper mapper)
        {
            _repositoryProbability = repositoryProbability;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetProbabilityDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Probability>, IEnumerable<GetProbabilityDTO>>(await _repositoryProbability.GetAll());

        }
        public async Task<GetProbabilityDTO> GetById(int id)
        {
            var probability = _mapper.Map<Probability, GetProbabilityDTO>(await _repositoryProbability.GetById(id));

            if (probability == null)
                throw new ArgumentException("Probability Não Existe");

            return probability;
        }
        public async Task Register(ProbabilityDTO dto)
        {

            var entidade = _mapper.Map<ProbabilityDTO, Probability>(dto);

            await _repositoryProbability.Add(entidade);
        }

        public async Task Update(UpdateProbabilityDTO probability)
        {
            var probabilityDB = await _repositoryProbability.GetById(probability.Id);

            if (probabilityDB == null)
            {
                throw new ArgumentException("Probability Não Existe");
            }

            probabilityDB.Probabilitys = probability.Probabilitys;

            await _repositoryProbability.Update(probabilityDB);
        }

        public async Task Delete(int id)
        {
            var probabilityDB = await _repositoryProbability.GetById(id);

            if (probabilityDB == null)
            {
                throw new ArgumentException("Probability Não Existe");
            }

            await _repositoryProbability.Remove(probabilityDB);

        }


    }
}
