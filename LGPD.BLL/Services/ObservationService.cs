using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_BLL.Services
{
    public class ObservationService : IObservationService
    {
        private readonly IObservationRepository _repositoryObservation;
        private readonly IMapper _mapper;

        public ObservationService(IObservationRepository repositoryObservation,
            IMapper mapper)
        {
            _repositoryObservation = repositoryObservation;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetObservationDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Observation>, IEnumerable<GetObservationDTO>>(await _repositoryObservation.GetAll());

        }
        public async Task<GetObservationDTO> GetById(int id)
        {
            var probability = _mapper.Map<Observation, GetObservationDTO>(await _repositoryObservation.GetById(id));

            if (probability == null)
                throw new ArgumentException("Observation Não Existe");

            return probability;
        }
        public async Task Register(ObservationDTO dto)
        {

            var entidade = _mapper.Map<ObservationDTO, Observation>(dto);

            await _repositoryObservation.Add(entidade);
        }

        public async Task Update(UpdateObservationDTO observation)
        {
            var observationDB = await _repositoryObservation.GetById(observation.Id);

            if (observationDB == null)
            {
                throw new ArgumentException("Observation Não Existe");
            }

            observationDB.Observations = observation.Observations;

            await _repositoryObservation.Update(observationDB);
        }

        public async Task Delete(int id)
        {
            var observationDB = await _repositoryObservation.GetById(id);

            if (observationDB == null)
            {
                throw new ArgumentException("Observation Não Existe");
            }

            await _repositoryObservation.Remove(observationDB);

        }


    }
}
