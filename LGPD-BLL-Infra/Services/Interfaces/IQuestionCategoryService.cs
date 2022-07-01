using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;

namespace LGPD_BLL_Infra.Services.Interfaces
{
    public interface IQuestionCategoryService
    {
        Task<IEnumerable<GetQuestionCategoryDTO>> GetAll();
        Task Register(QuestionCategoryDTO dto);
        Task Update(UpdateQuestionCategoryDTO reportPeriod);
        Task Delete(int id);
        Task<GetQuestionCategoryDTO> GetById(int id);

    }
}
