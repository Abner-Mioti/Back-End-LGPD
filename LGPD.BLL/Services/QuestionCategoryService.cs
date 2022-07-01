using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_BLL.Services
{
    public class QuestionCategoryService : IQuestionCategoryService
    {
        private readonly IQuestionCategoryRepositoy _repositoryQuestionCategory;
        private readonly IMapper _mapper;

        public QuestionCategoryService(IQuestionCategoryRepositoy repositoryQuestionCategory,
            IMapper mapper)
        {
            _repositoryQuestionCategory = repositoryQuestionCategory;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetQuestionCategoryDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<QuestionCategory>, IEnumerable<GetQuestionCategoryDTO>>(await _repositoryQuestionCategory.GetAll());

        }
        public async Task<GetQuestionCategoryDTO> GetById(int id)
        {
            var quest = _mapper.Map<QuestionCategory, GetQuestionCategoryDTO>(await _repositoryQuestionCategory.ObterPorId(id));

            if (quest == null)
                throw new ArgumentException("Question Category Não Existe");

            return quest;
        }
        public async Task Register(QuestionCategoryDTO dto)
        {

            var entidade = _mapper.Map<QuestionCategoryDTO, QuestionCategory>(dto);

            await _repositoryQuestionCategory.Adicionar(entidade);
        }

        public async Task Update(UpdateQuestionCategoryDTO quest)
        {
            var questDB = await _repositoryQuestionCategory.ObterPorId(quest.Id);

            if (questDB == null)
            {
                throw new ArgumentException("Question Category Não Existe");
            }

            questDB.Category = quest.Category;

            await _repositoryQuestionCategory.Atualizar(questDB);
        }

        public async Task Delete(int id)
        {
            var workshopDB = await _repositoryQuestionCategory.ObterPorId(id);

            if (workshopDB == null)
            {
                throw new ArgumentException("Question Category  Não Existe");
            }

            await _repositoryQuestionCategory.Remover(workshopDB);

        }

    }
}
