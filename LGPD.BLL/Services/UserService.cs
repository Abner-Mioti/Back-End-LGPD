using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repositoryUsuario;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repositoryUsuario,
            IMapper mapper)
        {
            _repositoryUsuario = repositoryUsuario;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetUserDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<User>, IEnumerable<GetUserDTO>>(await _repositoryUsuario.GetAll());

        }
        public async Task<GetUserDTO> GetById(int id)
        {
            var report = _mapper.Map<User, GetUserDTO>(await _repositoryUsuario.GetById(id));

            if (report == null)
                throw new ArgumentException("Usuario Não Existe");

            return report;
        }
        public async Task Register(UserDTO dto)
        {

            var entidade = _mapper.Map<UserDTO, User>(dto);

            await _repositoryUsuario.Add(entidade);
        }

        public async Task Update(UpdateUserDTO usuario)
        {
            var usuarioDB = await _repositoryUsuario.GetById(usuario.Id);

            if (usuarioDB == null)
            {
                throw new ArgumentException("Usuario Não Existe");
            }

            usuarioDB.AreaId = usuario.AreaId;
            usuarioDB.CompanyId = usuario.CompanyId;
            usuarioDB.Name = usuario.Name;
            usuarioDB.Email = usuario.Email;
            usuarioDB.JobTitle = usuario.JobTitle;
            usuarioDB.Mobile = usuario.Mobile;
            usuarioDB.Users = usuario.User;
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
