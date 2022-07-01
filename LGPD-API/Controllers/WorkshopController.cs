using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.AtualizarDTO;
using LGPD_MDE.Dto.Get;
using LGPD_MDE.Models.Model;
using LGPD_MDE.Models.Model.ModelAtualizar;
using LGPD_MDE.Models.Model.ModelGet;
using Microsoft.AspNetCore.Mvc;

namespace LGPD_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class WorkshopController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IWorkshopService _workshopService;
        private readonly IExceptionService _exceptionService;
        public WorkshopController(
            IMapper mapper,
            IWorkshopService workshopService,
            IExceptionService exceptionService)
        {
            _mapper = mapper;
            _exceptionService = exceptionService;
            _workshopService = workshopService;
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(_mapper.Map<GetWorkshopDTO, GetWorkshopModel>(await _workshopService.GetById(id)));
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter Workshop");
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                IEnumerable<GetWorkshopDTO> response = await _workshopService.GetAll();
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
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao obter todos os Workshops");
            }
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromForm] WorkshopModel cadastroWorkshop)
        {
            try
            {
                WorkshopDTO cadastroWorkshopDTO = _mapper.Map<WorkshopModel, WorkshopDTO>(cadastroWorkshop);
                await _workshopService.Register(cadastroWorkshop);
                return await Task.FromResult(Ok("Workshop cadastrado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao cadastrar Workshop");
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromForm] UpdateWorkshopModel workshop)
        {

            try
            {
                UpdateWorkshopDTO atualizarWorkshop = _mapper.Map<UpdateWorkshopModel, UpdateWorkshopDTO>(workshop);
                await _workshopService.Update(atualizarWorkshop);
                return await Task.FromResult(Ok("Workshop Alterado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao atualizar Workshop");
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _workshopService.Delete(id);
                return await Task.FromResult(Ok("Workshop Deletado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao deletar Workshop");
            }
        }
    }
}

