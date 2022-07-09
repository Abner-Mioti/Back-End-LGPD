using AutoMapper;
using LGPD_BLL_Infra.Services.Interfaces;
using LGPD_MDE.Dto;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_BLL.Services
{
    public class ExceptionService : IExceptionService
    {
        private readonly IExceptionRepository _exceptionRepository;
        private readonly IMapper _mapper;

        public ExceptionService(IMapper mapper, IExceptionRepository exceptionRepository)
        {
            _mapper = mapper;
            _exceptionRepository = exceptionRepository;
        }

        public async Task Log(Exception ex)
        {
            ExceptionsDTO exDto = new ExceptionsDTO();
            exDto.Description = ex.StackTrace?.ToString();
            if (exDto.Description.Length > 1000)
                exDto.Description = exDto.Description.Substring(0, 1000);
            exDto.Date = DateTime.Now;
            exDto.Message = ex.Message;
            if (exDto.Message.Length > 100)
                exDto.Message = exDto.Message.Substring(0, 100);
            await _exceptionRepository.Add(_mapper.Map<ExceptionsDTO, Exceptions>(exDto));
        }

        public Task Log(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
            return Task.CompletedTask;
        }

    }
}
