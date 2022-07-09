using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;

namespace LGPD_BLL_Infra.Services.Interfaces
{
    public interface ICompanyService
    {
        Task Register(CompanyDTO enterprise);

        Task<IEnumerable<GetCompanyDTO>> GetAll();

        Task<GetCompanyDTO> GetById(int id);

        Task Delete(int id);

        Task Update(UpdateCompanyDTO enteprise);

    }
}
