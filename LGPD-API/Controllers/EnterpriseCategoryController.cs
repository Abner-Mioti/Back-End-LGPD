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
    public class EnterpriseCategoryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IEnterpriseCategoryService _enterpriseCategoryService;
        private readonly IExceptionService _exceptionService;
        public EnterpriseCategoryController(
            IMapper mapper,
            IEnterpriseCategoryService enterpriseCategoryService,
            IExceptionService exceptionService)
        {
            _mapper = mapper;
            _exceptionService = exceptionService;
            _enterpriseCategoryService = enterpriseCategoryService;
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(_mapper.Map<GetEnterpriseCategoryDTO, GetEnterpriseCategoryModel>(await _enterpriseCategoryService.GetById(id)));
            }
            catch (BadHttpRequestException ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter Enterprise Category");
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                IEnumerable<GetEnterpriseCategoryDTO> response = await _enterpriseCategoryService.GetAll();
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
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao obter todos as Enterprises Category");
            }
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromForm] EnterpriseCategoryModel cadastroEnterpriseCategory)
        {
            try
            {
                EnterpriseCategoryDTO enterpriseCategory = _mapper.Map<EnterpriseCategoryModel, EnterpriseCategoryDTO>(cadastroEnterpriseCategory);
                await _enterpriseCategoryService.Register(enterpriseCategory);
                return await Task.FromResult(Ok("Enterprise Category cadastrada com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao cadastrar Enterprise Category");
            }
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromForm] UpdateEnterpriseCategoryModel enterprise)
        {

            try
            {
                UpdateEnterpriseCategoryDTO atualizarEnterprise = _mapper.Map<UpdateEnterpriseCategoryModel, UpdateEnterpriseCategoryDTO>(enterprise);
                await _enterpriseCategoryService.Update(atualizarEnterprise);
                return await Task.FromResult(Ok("Enterprise Category Alterado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao atualizar Enterprise Category");
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _enterpriseCategoryService.Delete(id);
                return await Task.FromResult(Ok("Enterprise Category Deletado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao deletar Enterprise Category");
            }
        }
    }
}
