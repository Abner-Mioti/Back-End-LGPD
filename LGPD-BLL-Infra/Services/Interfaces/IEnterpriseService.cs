using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;

namespace LGPD_BLL_Infra.Services.Interfaces
{
    public interface IEnterpriseService
    {
        Task Register(EnterpriseDTO enterprise);

        Task<IEnumerable<GetEnterpriseDTO>> GetAll();

        Task<GetEnterpriseDTO> GetById(int id);

        Task Delete(int id);

        Task Update(UpdateEnterpriseDTO enteprise);

    }
}
