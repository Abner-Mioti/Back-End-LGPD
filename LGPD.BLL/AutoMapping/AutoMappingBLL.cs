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
            CreateMap<EnterpriseDTO, Enterprise>().ReverseMap();
            CreateMap<GetEnterpriseDTO, Enterprise>().ReverseMap();
            CreateMap<UpdateEnterpriseDTO, Enterprise>().ReverseMap();
            CreateMap<GetFieldDTO, Field>().ReverseMap();
            CreateMap<FieldDTO, Field>().ReverseMap();
            CreateMap<UpdateFieldDTO, Field>().ReverseMap();
            CreateMap<GetEnterpriseCategoryDTO, EnterpriseCategory>().ReverseMap();
            CreateMap<EnterpriseCategoryDTO, EnterpriseCategory>().ReverseMap();
            CreateMap<GetEnterpriseCategoryDTO, EnterpriseCategory>().ReverseMap();
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


            






        }
    }
}
