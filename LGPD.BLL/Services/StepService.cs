using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_BLL.Services
{
    public class StepService : IStepService
    {
        private readonly IStepRepository _repositoryStep;
        private readonly IMapper _mapper;

        public StepService(IStepRepository repositoryStep,
            IMapper mapper)
        {
            _repositoryStep = repositoryStep;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetStepDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Step>, IEnumerable<GetStepDTO>>(await _repositoryStep.GetAll());

        }
        public async Task<GetStepDTO> GetById(int id)
        {
            var quest = _mapper.Map<Step, GetStepDTO>(await _repositoryStep.GetById(id));

            if (quest == null)
                throw new ArgumentException("Step Não Existe");

            return quest;
        }
        public async Task Register(StepDTO dto)
        {

            var entidade = _mapper.Map<StepDTO, Step>(dto);

            await _repositoryStep.Add(entidade);
        }

        public async Task Update(UpdateStepDTO step)
        {
            var stepDB = await _repositoryStep.GetById(step.Id);

            if (stepDB == null)
            {
                throw new ArgumentException("Step Não Existe");
            }

            stepDB.Steps = step.Steps;
            stepDB.Value = step.Value;
            stepDB.CloseDate = step.CloseDate;
            stepDB.EndDate = step.EndDate;
            stepDB.Itens = step.Itens;
            stepDB.Active = step.Active;

            await _repositoryStep.Update(stepDB);
        }

        public async Task Delete(int id)
        {
            var stepDB = await _repositoryStep.GetById(id);

            if (stepDB == null)
            {
                throw new ArgumentException("Step Não Existe");
            }

            await _repositoryStep.Remove(stepDB);

        }

    }
}
