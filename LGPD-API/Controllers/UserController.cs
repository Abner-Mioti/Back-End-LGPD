using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using LGPD_MDE.Models.Model;
using LGPD_MDE.Models.Model.GetModel;
using LGPD_MDE.Models.Model.UpdateModel;
using Microsoft.AspNetCore.Mvc;

namespace LGPD_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _usuarioService;
        private readonly IExceptionService _exceptionService;
        public UserController(

            IMapper mapper,
            IUserService usuarioService,
            IExceptionService exceptionService)
        {
            _mapper = mapper;
            _usuarioService = usuarioService;
            _exceptionService = exceptionService;
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(_mapper.Map<GetUserDTO, GetUserModel>(await _usuarioService.GetById(id)));
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter User");
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                IEnumerable<GetUserDTO> response = await _usuarioService.GetAll();
                var x = response.ToList();
                return Ok(response);
            }
            catch (BadHttpRequestException ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao obter todos as User");
            }
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromForm] UserModel cadastroUsuario)
        {
            try
            {
                UserDTO cadastroUsuarioDTO = _mapper.Map<UserModel, UserDTO>(cadastroUsuario);
                await _usuarioService.Register(cadastroUsuarioDTO);
                return await Task.FromResult(Ok("User cadastrada com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao cadastrar User");
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromForm] UpdateUserModel usuario)
        {

            try
            {
                UpdateUserDTO atualizarQuestion = _mapper.Map<UpdateUserModel, UpdateUserDTO>(usuario);
                await _usuarioService.Update(atualizarQuestion);
                return await Task.FromResult(Ok("User Alterado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao atualizar User");
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _usuarioService.Delete(id);
                return await Task.FromResult(Ok("User Deletado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao deletar User");
            }
        }


    }
}
