using AutoMapper;
using LGPD_BLL.Infra.Services.Interfaces;
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



    }
}
