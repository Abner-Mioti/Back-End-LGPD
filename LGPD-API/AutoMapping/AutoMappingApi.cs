using AutoMapper;
using LGPD_MDE.Dto;
using LGPD_MDE.Dto.AtualizarDTO;
using LGPD_MDE.Dto.Get;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;
using LGPD_MDE.Models.Model;
using LGPD_MDE.Models.Model.GetModel;
using LGPD_MDE.Models.Model.ModelAtualizar;
using LGPD_MDE.Models.Model.ModelGet;
using LGPD_MDE.Models.Model.UpdateModel;

namespace LGPD_API.AutoMapping
{
    public class AutoMappingApi : Profile
    {
        public AutoMappingApi()
        {
            CreateMap<WorkshopModel, WorkshopDTO>().ReverseMap();
            CreateMap<UpdateWorkshopModel, UpdateWorkshopDTO>().ReverseMap();
            CreateMap<GetWorkshopModel, GetWorkshopDTO>().ReverseMap();
            CreateMap<CompanyModel, CompanyDTO>().ReverseMap();
            CreateMap<GetCompanyModel, GetCompanyDTO>().ReverseMap();
            CreateMap<UpdateCompanyModel, UpdateCompanyDTO>().ReverseMap();
            CreateMap<UpdateFieldModel, UpdateFieldDTO>().ReverseMap();
            CreateMap<FieldModel, FieldDTO>().ReverseMap();
            CreateMap<GetFieldModel, GetFieldDTO>().ReverseMap();
            CreateMap<UpdateCompanyCategoryModel, UpdateCompanyCategoryDTO>().ReverseMap();
            CreateMap<CompanyCategoryModel, CompanyCategoryDTO>().ReverseMap();
            CreateMap<GetCompanyCategoryModel, GetCompanyCategoryDTO>().ReverseMap();
            CreateMap<GetReportPeriodModel, GetReportPeriodDTO>().ReverseMap();
            CreateMap<ReportPeriodModel, ReportPeriodDTO>().ReverseMap();
            CreateMap<UpdateReportPeriodModel, UpdateReportPeriodDTO>().ReverseMap();
            CreateMap<GetAreaModel, GetAreaDTO>().ReverseMap();
            CreateMap<AreaModel, AreaDTO>().ReverseMap();
            CreateMap<UpdateAreaModel, UpdateAreaDTO>().ReverseMap();
            CreateMap<UpdateQuestionCategoryModel, UpdateQuestionCategoryDTO>().ReverseMap();
            CreateMap<QuestionCategoryModel, QuestionCategoryDTO>().ReverseMap();
            CreateMap<GetQuestionCategoryModel, GetQuestionCategoryDTO>().ReverseMap();
            CreateMap<GetImpactModel, GetImpactDTO>().ReverseMap();
            CreateMap<ImpactModel, ImpactDTO>().ReverseMap();
            CreateMap<UpdateImpactModel, UpdateImpactDTO>().ReverseMap();
            CreateMap<UpdateProbabilityModel, UpdateProbabilityDTO>().ReverseMap();
            CreateMap<GetProbabilityModel, GetProbabilityDTO>().ReverseMap();
            CreateMap<ProbabilityModel, ProbabilityDTO>().ReverseMap();
            CreateMap<QuestionModel, QuestionDTO>().ReverseMap();
            CreateMap<GetQuestionModel, GetQuestionDTO>().ReverseMap();
            CreateMap<UpdateQuestionModel, UpdateQuestionDTO>().ReverseMap();
            CreateMap<UpdateRiskModel, UpdateRiskDTO>().ReverseMap();
            CreateMap<GetRiskModel, GetRiskDTO>().ReverseMap();
            CreateMap<RiskModel, RiskDTO>().ReverseMap();
            CreateMap<UserModel, UserDTO>().ReverseMap();
            CreateMap<GetUserModel, GetUserDTO>().ReverseMap();
            CreateMap<UpdateUserModel, UpdateUserDTO>().ReverseMap();
            CreateMap<UpdateObservationModel, UpdateObservationDTO>().ReverseMap();
            CreateMap<GetObservationModel, GetObservationDTO>().ReverseMap();
            CreateMap<ObservationModel, ObservationDTO>().ReverseMap();
            CreateMap<StepModel, StepDTO>().ReverseMap();
            CreateMap<UpdateStepModel, UpdateStepDTO>().ReverseMap();
            CreateMap<GetStepModel, GetStepDTO>().ReverseMap();

        }

    }
}
