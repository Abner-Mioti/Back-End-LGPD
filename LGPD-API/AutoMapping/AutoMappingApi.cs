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
            CreateMap<EnterpriseModel, EnterpriseDTO>().ReverseMap();
            CreateMap<GetEnterpriseModel, GetEnterpriseDTO>().ReverseMap();
            CreateMap<UpdateEnterpriseModel, UpdateEnterpriseDTO>().ReverseMap();
            CreateMap<UpdateFieldModel, UpdateFieldDTO>().ReverseMap();
            CreateMap<FieldModel, FieldDTO>().ReverseMap();
            CreateMap<GetFieldModel, GetFieldDTO>().ReverseMap();
            CreateMap<UpdateEnterpriseCategoryModel, UpdateEnterpriseCategoryDTO>().ReverseMap();
            CreateMap<EnterpriseCategoryModel, EnterpriseCategoryDTO>().ReverseMap();
            CreateMap<GetEnterpriseCategoryModel, GetEnterpriseCategoryDTO>().ReverseMap();
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

        }

    }
}
