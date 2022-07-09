﻿using LGPD_MDE.Entities;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository.Repositories.Generico;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_Repository.Repositories
{
    public class RiskRepository : RepositoryLGPD<Risk>, IRiskRepository
    {
        public RiskRepository(LgpdDbContext context) : base(context)
        {

        }

    }
}
