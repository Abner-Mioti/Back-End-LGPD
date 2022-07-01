using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;

namespace LGPD_BLL_Infra.Services.Interfaces
{
    public interface IEnterpriseCategoryService
    {
        Task<IEnumerable<GetEnterpriseCategoryDTO>> GetAll();
        Task Register(EnterpriseCategoryDTO dto);
        Task Update(UpdateEnterpriseCategoryDTO workshop);
        Task Delete(int id);
        Task<GetEnterpriseCategoryDTO> GetById(int id);

    }
}
