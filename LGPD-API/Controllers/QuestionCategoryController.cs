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
    public class QuestionCategoryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IQuestionCategoryService _questionCategoryService;
        private readonly IExceptionService _exceptionService;
        public QuestionCategoryController(

            IMapper mapper,
            IQuestionCategoryService questionCategoryService,
            IExceptionService exceptionService)
        {
            _mapper = mapper;
            _questionCategoryService = questionCategoryService;
            _exceptionService = exceptionService;
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(_mapper.Map<GetQuestionCategoryDTO, GetQuestionCategoryModel>(await _questionCategoryService.GetById(id)));
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter Question Category");
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                IEnumerable<GetQuestionCategoryDTO> response = await _questionCategoryService.GetAll();
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
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao obter todos as Question Category");
            }
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromForm] QuestionCategoryModel cadastroQuestionCategory)
        {
            try
            {
                QuestionCategoryDTO cadastroQuestionCategoryDTO = _mapper.Map<QuestionCategoryModel, QuestionCategoryDTO>(cadastroQuestionCategory);
                await _questionCategoryService.Register(cadastroQuestionCategoryDTO);
                return await Task.FromResult(Ok("Question Category cadastrada com sucesso! "));
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
        public async Task<IActionResult> Update([FromForm] UpdateQuestionCategoryModel questionCategory)
        {

            try
            {
                UpdateQuestionCategoryDTO atualizarQuestionCategory = _mapper.Map<UpdateQuestionCategoryModel, UpdateQuestionCategoryDTO>(questionCategory);
                await _questionCategoryService.Update(atualizarQuestionCategory);
                return await Task.FromResult(Ok("Question Category Alterado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao atualizar Question Category");
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _questionCategoryService.Delete(id);
                return await Task.FromResult(Ok("Question Category Deletado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao deletar Question Category");
            }
        }
    }
}
