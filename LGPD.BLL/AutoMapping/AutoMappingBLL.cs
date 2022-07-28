using AutoMapper;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.AtualizarDTO;
using LGPD_MDE.Dto.Get;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using LGPD_MDE.Entities.Generated;

namespace LGPD_BLL.AutoMapping
{
    public class AutoMappingBLL : Profile
    {
        public AutoMappingBLL()
        {
            CreateMap<ExceptionsDTO, Exceptions>().ReverseMap();
            CreateMap<WorkshopDTO, Workshop>().ReverseMap();
            CreateMap<UpdateWorkshopDTO, Workshop>().ReverseMap();
            CreateMap<GetWorkshopDTO, Workshop>().ReverseMap();
            CreateMap<CompanyDTO, Company>().ReverseMap();
            CreateMap<GetCompanyDTO, Company>().ReverseMap();
            CreateMap<UpdateCompanyDTO, Company>().ReverseMap();
            CreateMap<GetFieldDTO, Field>().ReverseMap();
            CreateMap<FieldDTO, Field>().ReverseMap();
            CreateMap<UpdateFieldDTO, Field>().ReverseMap();
            CreateMap<GetCompanyCategoryDTO, CompanyCategory>().ReverseMap();
            CreateMap<CompanyCategoryDTO, CompanyCategory>().ReverseMap();
            CreateMap<GetCompanyCategoryDTO, CompanyCategory>().ReverseMap();
            CreateMap<ReportPeriodDTO, ReportPeriod>().ReverseMap();
            CreateMap<GetReportPeriodDTO, ReportPeriod>().ReverseMap();
            CreateMap<UpdateReportPeriodDTO, ReportPeriod>().ReverseMap();
            CreateMap<GetAreaDTO, Area>().ReverseMap();
            CreateMap<UpdateAreaDTO, Area>().ReverseMap();
            CreateMap<AreaDTO, Area>().ReverseMap();
            CreateMap<UpdateQuestionCategoryDTO, QuestionCategory>().ReverseMap();
            CreateMap<GetQuestionCategoryDTO, QuestionCategory>().ReverseMap();
            CreateMap<QuestionCategoryDTO, QuestionCategory>().ReverseMap();
            CreateMap<ImpactDTO, Impact>().ReverseMap();
            CreateMap<UpdateImpactDTO, Impact>().ReverseMap();
            CreateMap<GetImpactDTO, Impact>().ReverseMap();
            CreateMap<GetProbabilityDTO, Probability>().ReverseMap();
            CreateMap<UpdateProbabilityDTO, Probability>().ReverseMap();
            CreateMap<ProbabilityDTO, Probability>().ReverseMap();
            CreateMap<QuestionDTO, Question>().ReverseMap();
            CreateMap<GetQuestionDTO, Question>().ReverseMap();
            CreateMap<UpdateQuestionDTO, Question>().ReverseMap();
            CreateMap<UpdateRiskDTO, Risk>().ReverseMap();
            CreateMap<GetRiskDTO, Risk>().ReverseMap();
            CreateMap<RiskDTO, Risk>().ReverseMap();
            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<GetUserDTO, User>().ReverseMap();
            CreateMap<UpdateUserDTO, User>().ReverseMap();
            CreateMap<ObservationDTO, Observation>().ReverseMap();
            CreateMap<GetObservationDTO, Observation>().ReverseMap();
            CreateMap<UpdateObservationDTO, Observation>().ReverseMap();
            CreateMap<UpdateStepDTO, Step>().ReverseMap();
            CreateMap<GetStepDTO, Step>().ReverseMap();
            CreateMap<StepDTO, Step>().ReverseMap();


        }
    }
}
