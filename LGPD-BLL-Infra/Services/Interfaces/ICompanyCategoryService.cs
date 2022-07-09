using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;

namespace LGPD_BLL_Infra.Services.Interfaces
{
    public interface ICompanyCategoryService
    {
        Task<IEnumerable<GetCompanyCategoryDTO>> GetAll();
        Task Register(CompanyCategoryDTO dto);
        Task Update(UpdateCompanyCategoryDTO workshop);
        Task Delete(int id);
        Task<GetCompanyCategoryDTO> GetById(int id);

    }
}
