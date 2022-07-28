using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_BLL.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _repositoryQuestion;
        private readonly IMapper _mapper;

        public QuestionService(IQuestionRepository repositoryQuestion,
            IMapper mapper)
        {
            _repositoryQuestion = repositoryQuestion;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetQuestionDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Question>, IEnumerable<GetQuestionDTO>>(await _repositoryQuestion.GetAll());

        }
        public async Task<GetQuestionDTO> GetById(int id)
        {
            var quest = _mapper.Map<Question, GetQuestionDTO>(await _repositoryQuestion.GetById(id));

            if (quest == null)
                throw new ArgumentException("Question Não Existe");

            return quest;
        }
        public async Task Register(QuestionDTO dto)
        {

            var entidade = _mapper.Map<QuestionDTO, Question>(dto);

            await _repositoryQuestion.Add(entidade);
        }

        public async Task Update(UpdateQuestionDTO quest)
        {
            var questDB = await _repositoryQuestion.GetById(quest.Id);

            if (questDB == null)
            {
                throw new ArgumentException("Question Não Existe");
            }

            questDB.AreaId = quest.AreaId;
            questDB.ObservationId = quest.ObservationId;
            questDB.QuestionCategoryId = quest.QuestionCategoryId;
            questDB.ImpactId = quest.ImpactId;
            questDB.ProbabilityId = quest.ProbabilityId;
            questDB.Wording = quest.Wording;
            questDB.Reply = quest.Reply;
            questDB.RepliedStatus = quest.RepliedStatus;
            questDB.SuitableStatus = quest.SuitableStatus;
            questDB.Effect = quest.Effect;
            questDB.Action = quest.Action;


            await _repositoryQuestion.Update(questDB);
        }

        public async Task Delete(int id)
        {
            var questDB = await _repositoryQuestion.GetById(id);

            if (questDB == null)
            {
                throw new ArgumentException("Question Não Existe");
            }

            await _repositoryQuestion.Remove(questDB);

        }

    }
}
