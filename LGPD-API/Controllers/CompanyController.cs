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
    public class CompanyController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICompanyService _enterpriseService;
        private readonly IExceptionService _exceptionService;
        public CompanyController(
            IMapper mapper,
            ICompanyService enterpriseService,
            IExceptionService exceptionService)
        {
            _mapper = mapper;
            _exceptionService = exceptionService;
            _enterpriseService = enterpriseService;
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(_mapper.Map<GetCompanyDTO, GetCompanyModel>(await _enterpriseService.GetById(id)));
            }
            catch (BadHttpRequestException ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter Enterprise");
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                IEnumerable<GetCompanyDTO> response = await _enterpriseService.GetAll();
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
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao obter todos as Enterprises");
            }
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromForm] CompanyModel cadastroEnterprise)
        {
            try
            {
                CompanyDTO enterprise = _mapper.Map<CompanyModel, CompanyDTO>(cadastroEnterprise);
                await _enterpriseService.Register(enterprise);
                return await Task.FromResult(Ok("Enterprise cadastrada com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao cadastrar Enterprise");
            }
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromForm] UpdateCompanyModel enterprise)
        {

            try
            {
                UpdateCompanyDTO atualizarEnterprise = _mapper.Map<UpdateCompanyModel, UpdateCompanyDTO>(enterprise);
                await _enterpriseService.Update(atualizarEnterprise);
                return await Task.FromResult(Ok("Enterprise Alterado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao atualizar Enterprise");
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _enterpriseService.Delete(id);
                return await Task.FromResult(Ok("Enterprise Deletado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao deletar Enterprise");
            }
        }
    }
}
