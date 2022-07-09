using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;

namespace LGPD_BLL_Infra.Services.Interfaces
{
    public interface IQuestionService
    {
        Task<IEnumerable<GetQuestionDTO>> GetAll();
        Task Register(QuestionDTO dto);
        Task Update(UpdateQuestionDTO reportQuestion);
        Task Delete(int id);
        Task<GetQuestionDTO> GetById(int id);

    }
}
