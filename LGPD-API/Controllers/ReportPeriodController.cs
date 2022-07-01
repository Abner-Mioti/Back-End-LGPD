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
    public class ReportPeriodController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IReportPeriodService _reportPeriodService;
        private readonly IExceptionService _exceptionService;
        public ReportPeriodController(
            IMapper mapper,
            IReportPeriodService reportPeriodService,
            IExceptionService exceptionService)
        {
            _mapper = mapper;
            _exceptionService = exceptionService;
            _reportPeriodService = reportPeriodService;
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(_mapper.Map<GetReportPeriodDTO, GetReportPeriodModel>(await _reportPeriodService.GetById(id)));
            }
            catch (BadHttpRequestException ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter Report Period");
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                IEnumerable<GetReportPeriodDTO> response = await _reportPeriodService.GetAll();
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
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao obter todos os Report Period");
            }
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromForm] ReportPeriodModel reportPeridod)
        {
            try
            {
                ReportPeriodDTO reportPeridodDTO = _mapper.Map<ReportPeriodModel, ReportPeriodDTO>(reportPeridod);
                await _reportPeriodService.Register(reportPeridodDTO);
                return await Task.FromResult(Ok("Report Period cadastrado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao cadastrar Report Period");
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromForm] UpdateReportPeriodModel workshop)
        {

            try
            {
                UpdateReportPeriodDTO atualizarWorkshop = _mapper.Map<UpdateReportPeriodModel, UpdateReportPeriodDTO>(workshop);
                await _reportPeriodService.Update(atualizarWorkshop);
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
                await _reportPeriodService.Delete(id);
                return await Task.FromResult(Ok("Report Period Deletado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao deletar Report Period");
            }
        }
    }
}
