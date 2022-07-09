using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_BLL.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repositoryUsuario;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository repositoryUsuario,
            IMapper mapper)
        {
            _repositoryUsuario = repositoryUsuario;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetUsuarioDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Usuario>, IEnumerable<GetUsuarioDTO>>(await _repositoryUsuario.GetAll());

        }
        public async Task<GetUsuarioDTO> GetById(int id)
        {
            var report = _mapper.Map<Usuario, GetUsuarioDTO>(await _repositoryUsuario.GetById(id));

            if (report == null)
                throw new ArgumentException("Usuario Não Existe");

            return report;
        }
        public async Task Register(UsuarioDTO dto)
        {

            var entidade = _mapper.Map<UsuarioDTO, Usuario>(dto);

            await _repositoryUsuario.Add(entidade);
        }

        public async Task Update(UpdateUsuarioDTO usuario)
        {
            var usuarioDB = await _repositoryUsuario.GetById(usuario.Id);

            if (usuarioDB == null)
            {
                throw new ArgumentException("Usuario Não Existe");
            }

            usuarioDB.Name = usuario.Name;
            usuarioDB.Email = usuario.Email;
            usuarioDB.JobTitle = usuario.JobTitle;
            usuarioDB.Mobile = usuario.Mobile;
            usuarioDB.User = usuario.User;
            usuarioDB.Password = usuario.Password;
            usuarioDB.IsActive = usuario.IsActive;

            await _repositoryUsuario.Update(usuarioDB);
        }

        public async Task Delete(int id)
        {
            var usuarioDB = await _repositoryUsuario.GetById(id);

            if (usuarioDB == null)
            {
                throw new ArgumentException("Usuario Não Existe");
            }

            await _repositoryUsuario.Remove(usuarioDB);

        }
    }
}
