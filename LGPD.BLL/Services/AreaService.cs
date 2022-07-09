using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_BLL.Services
{
    public class AreaService : IAreaService
    {
        private readonly IAreaRepository _repositoryArea;
        private readonly IMapper _mapper;

        public AreaService(IAreaRepository repositoryArea,
            IMapper mapper)
        {
            _repositoryArea = repositoryArea;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetAreaDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Area>, IEnumerable<GetAreaDTO>>(await _repositoryArea.GetAll());

        }
        public async Task<GetAreaDTO> GetById(int id)
        {
            var area = _mapper.Map<Area, GetAreaDTO>(await _repositoryArea.GetById(id));

            if (area == null)
                throw new ArgumentException("Area Não Existe");

            return area;
        }
        public async Task Register(AreaDTO dto)
        {

            var entidade = _mapper.Map<AreaDTO, Area>(dto);

            await _repositoryArea.Add(entidade);
        }

        public async Task Update(UpdateAreaDTO area)
        {
            var areaDB = await _repositoryArea.GetById(area.Id);

            if (areaDB == null)
            {
                throw new ArgumentException("Area Não Existe");
            }

            areaDB.Areas = area.Areas;

            await _repositoryArea.Update(areaDB);
        }

        public async Task Delete(int id)
        {
            var areaDB = await _repositoryArea.GetById(id);

            if (areaDB == null)
            {
                throw new ArgumentException("Area Não Existe");
            }

            await _repositoryArea.Remove(areaDB);

        }

    }
}
