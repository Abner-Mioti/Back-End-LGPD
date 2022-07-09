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
    public class RiskController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRiskService _riskService;
        private readonly IExceptionService _exceptionService;
        public RiskController(
            IMapper mapper,
            IRiskService riskService,
            IExceptionService exceptionService)
        {
            _mapper = mapper;
            _exceptionService = exceptionService;
            _riskService = riskService;
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(_mapper.Map<GetRiskDTO, GetRiskModel>(await _riskService.GetById(id)));
            }
            catch (BadHttpRequestException ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter Risk");
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                IEnumerable<GetRiskDTO> response = await _riskService.GetAll();
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
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao obter todos os Risk");
            }
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromForm] RiskModel risk)
        {
            try
            {
                RiskDTO riskDTO = _mapper.Map<RiskModel, RiskDTO>(risk);
                await _riskService.Register(riskDTO);
                return await Task.FromResult(Ok("Risk cadastrado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao cadastrar Risk");
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromForm] UpdateRiskModel risk)
        {

            try
            {
                UpdateRiskDTO atualizarRisk = _mapper.Map<UpdateRiskModel, UpdateRiskDTO>(risk);
                await _riskService.Update(atualizarRisk);
                return await Task.FromResult(Ok("Risk Alterado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao atualizar Risk");
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _riskService.Delete(id);
                return await Task.FromResult(Ok("Risk Deletado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao deletar Risk");
            }
        }

    }
}
