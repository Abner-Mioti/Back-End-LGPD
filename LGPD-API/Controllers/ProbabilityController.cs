﻿using AutoMapper;
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
    public class ProbabilityController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProbabilityService _probabilityService;
        private readonly IExceptionService _exceptionService;
        public ProbabilityController(

            IMapper mapper,
            IProbabilityService probabilityService,
            IExceptionService exceptionService)
        {
            _mapper = mapper;
            _probabilityService = probabilityService;
            _exceptionService = exceptionService;
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(_mapper.Map<GetProbabilityDTO, GetProbabilityModel>(await _probabilityService.GetById(id)));
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter Probability");
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                IEnumerable<GetProbabilityDTO> response = await _probabilityService.GetAll();
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
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao obter todos as Probability");
            }
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromForm] ProbabilityModel cadastroProbability)
        {
            try
            {
                ProbabilityDTO cadastroProbabilityDTO = _mapper.Map<ProbabilityModel, ProbabilityDTO>(cadastroProbability);
                await _probabilityService.Register(cadastroProbabilityDTO);
                return await Task.FromResult(Ok("Probability cadastrada com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao cadastrar Probability");
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromForm] UpdateProbabilityModel probability)
        {

            try
            {
                UpdateProbabilityDTO atualizarProbability = _mapper.Map<UpdateProbabilityModel, UpdateProbabilityDTO>(probability);
                await _probabilityService.Update(atualizarProbability);
                return await Task.FromResult(Ok("Probability Alterado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao atualizar Probability");
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _probabilityService.Delete(id);
                return await Task.FromResult(Ok("Probability Deletado com sucesso! "));
            }
            catch (ArgumentException ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                await _exceptionService.Log(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao deletar Probability");
            }
        }


    }
}
