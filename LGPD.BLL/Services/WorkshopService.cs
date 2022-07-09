using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.AtualizarDTO;
using LGPD_MDE.Dto.Get;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_BLL.Services
{
    public class WorkshopService : IWorkshopService
    {
        private readonly IWorkshopRepository _repositoryWorkshop;
        private readonly IMapper _mapper;

        public WorkshopService(IWorkshopRepository repositoryWorkshop,
            IMapper mapper)
        {
            _repositoryWorkshop = repositoryWorkshop;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetWorkshopDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Workshop>, IEnumerable<GetWorkshopDTO>>(await _repositoryWorkshop.GetAll());

        }
        public async Task<GetWorkshopDTO> GetById(int id)
        {
            var work = _mapper.Map<Workshop, GetWorkshopDTO>(await _repositoryWorkshop.GetById(id));

            if (work == null)
                throw new ArgumentException("Workshop Não Existe");

            return work;
        }
        public async Task Register(WorkshopDTO dto)
        {

            var entidade = _mapper.Map<WorkshopDTO, Workshop>(dto);

            await _repositoryWorkshop.Add(entidade);
        }

        public async Task Update(UpdateWorkshopDTO workshop)
        {
            var workshopDB = await _repositoryWorkshop.GetById(workshop.Id);

            if (workshopDB == null)
            {
                throw new ArgumentException("Workshop Não Existe");
            }

            workshopDB.MeetingLink = workshop.MeetingLink;
            workshopDB.Date = workshop.Date;

            await _repositoryWorkshop.Update(workshopDB);
        }

        public async Task Delete(int id)
        {
            var workshopDB = await _repositoryWorkshop.GetById(id);

            if (workshopDB == null)
            {
                throw new ArgumentException("Workshop Não Existe");
            }

            await _repositoryWorkshop.Remove(workshopDB);

        }
    }
}
