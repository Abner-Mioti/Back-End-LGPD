﻿using LGPD_MDE.Dto;
using LGPD_MDE.Dto.GetDTO;
using LGPD_MDE.Dto.UpdateDTO;

namespace LGPD_BLL_Infra.Services.Interfaces
{
    public interface IFieldService
    {
        Task<IEnumerable<GetFieldDTO>> GetAll();
        Task Register(FieldDTO dto);
        Task Update(UpdateFieldDTO field);
        Task Delete(int id);
        Task<GetFieldDTO> GetById(int id);

    }
}