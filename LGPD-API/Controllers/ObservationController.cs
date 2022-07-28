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
    public class ObservationController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IObservationService _observationService;
        private readonly IExceptionService _exceptionService;
        public ObservationController(

            IMapper mapper,
            IObservationService observationService,
            IExceptionService exceptionService)
        {
            _mapper = mapper;
            _observationService = observationService;
            _exceptionService = exceptionService;
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(_mapper.Map<GetObservationDTO, GetObservationModel>(await _observationService.GetById(id)));
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter Observation");
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                IEnumerable<GetObservationDTO> response = await _observationService.GetAll();
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
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao obter todos as Observation");
            }
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromForm] ObservationModel cadastroObservation)
        {
            try
            {
                ObservationDTO cadastroProbabilityDTO = _mapper.Map<ObservationModel, ObservationDTO>(cadastroObservation);
                await _observationService.Register(cadastroProbabilityDTO);
                return await Task.FromResult(Ok("Observation cadastrada com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao cadastrar Observation");
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromForm] UpdateObservationModel probability)
        {

            try
            {
                UpdateObservationDTO atualizarProbability = _mapper.Map<UpdateObservationModel, UpdateObservationDTO>(probability);
                await _observationService.Update(atualizarProbability);
                return await Task.FromResult(Ok("Observation Alterado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao atualizar Observation");
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _observationService.Delete(id);
                return await Task.FromResult(Ok("Observation Deletado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao deletar Observation");
            }
        }


    }
}
