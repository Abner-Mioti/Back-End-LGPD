using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGPD_BLL_Infra.Services.Interfaces
{
    public interface IAreaService
    {
        Task<IEnumerable<GetAreaDTO>> GetAll();
        Task Register(AreaDTO dto);
        Task Update(UpdateAreaDTO workshop);
        Task Delete(int id);
        Task<GetAreaDTO> GetById(int id);


    }
}
