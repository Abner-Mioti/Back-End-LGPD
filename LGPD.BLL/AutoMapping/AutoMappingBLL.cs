using AutoMapper;
using LGPD_MDE.Dto;
using LGPD_MDE.Entities.Generated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGPD_BLL.AutoMapping
{
    public class AutoMappingBLL : Profile
    {
        public AutoMappingBLL()
        {
            CreateMap<UsuarioDto, Usuario>().ReverseMap();
        }

    }
}
