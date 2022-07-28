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
    public class StepController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IStepService _stepService;
        private readonly IExceptionService _exceptionService;
        public StepController(
            IMapper mapper,
            IStepService stepService,
            IExceptionService exceptionService)
        {
            _mapper = mapper;
            _exceptionService = exceptionService;
            _stepService = stepService;
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(_mapper.Map<GetStepDTO, GetStepModel>(await _stepService.GetById(id)));
            }
            catch (BadHttpRequestException ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter Step");
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                IEnumerable<GetStepDTO> response = await _stepService.GetAll();
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
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao obter todos os Step");
            }
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromForm] StepModel risk)
        {
            try
            {
                StepDTO riskDTO = _mapper.Map<StepModel, StepDTO>(risk);
                await _stepService.Register(riskDTO);
                return await Task.FromResult(Ok("Step cadastrado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao cadastrar Step");
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromForm] UpdateStepModel step)
        {

            try
            {
                UpdateStepDTO atualizarRisk = _mapper.Map<UpdateStepModel, UpdateStepDTO>(step);
                await _stepService.Update(atualizarRisk);
                return await Task.FromResult(Ok("Step Alterado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao atualizar Step");
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _stepService.Delete(id);
                return await Task.FromResult(Ok("Step Deletado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao deletar Step");
            }
        }


    }
}
