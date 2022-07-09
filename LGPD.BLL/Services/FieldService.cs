using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_BLL.Services
{
    public class FieldService : IFieldService
    {
        private readonly IFieldRepository _repositoryField;
        private readonly IMapper _mapper;

        public FieldService(IFieldRepository repositoryField,
            IMapper mapper)
        {
            _repositoryField = repositoryField;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetFieldDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Field>, IEnumerable<GetFieldDTO>>(await _repositoryField.GetAll());

        }
        public async Task<GetFieldDTO> GetById(int id)
        {
            var field = _mapper.Map<Field, GetFieldDTO>(await _repositoryField.GetById(id));

            if (field == null)
                throw new ArgumentException("Field Não Existe");

            return field;
        }
        public async Task Register(FieldDTO dto)
        {

            var entidade = _mapper.Map<FieldDTO, Field>(dto);

            await _repositoryField.Add(entidade);
        }

        public async Task Update(UpdateFieldDTO field)
        {
            var fieldDB = await _repositoryField.GetById(field.Id);

            if (fieldDB == null)
            {
                throw new ArgumentException("Field Não Existe");
            }

            fieldDB.Fields = field.Fields;

            await _repositoryField.Update(fieldDB);
        }

        public async Task Delete(int id)
        {
            var fieldDB = await _repositoryField.GetById(id);

            if (fieldDB == null)
            {
                throw new ArgumentException("Field Não Existe");
            }

            await _repositoryField.Remove(fieldDB);

        }

    }
}
