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
    public class FieldController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IFieldService _fieldService;
        private readonly IExceptionService _exceptionService;
        public FieldController(

            IMapper mapper,
            IFieldService fieldService,
            IExceptionService exceptionService)
        {
            _mapper = mapper;
            _fieldService = fieldService;
            _exceptionService = exceptionService;
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(_mapper.Map<GetFieldDTO, GetFieldModel>(await _fieldService.GetById(id)));
            }
            catch (BadHttpRequestException ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter Field");
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                IEnumerable<GetFieldDTO> response = await _fieldService.GetAll();
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
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao obter todos as Field");
            }
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromForm] FieldModel cadastroField)
        {
            try
            {
                FieldDTO field = _mapper.Map<FieldModel, FieldDTO>(cadastroField);
                await _fieldService.Register(field);
                return await Task.FromResult(Ok("Field cadastrada com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao cadastrar Field");
            }
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromForm] UpdateFieldModel field)
        {

            try
            {
                UpdateFieldDTO atualizarField = _mapper.Map<UpdateFieldModel, UpdateFieldDTO>(field);
                await _fieldService.Update(atualizarField);
                return await Task.FromResult(Ok("Field Alterado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao atualizar Field");
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _fieldService.Delete(id);
                return await Task.FromResult(Ok("Field Deletado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao deletar Field");
            }
        }

    }
}
