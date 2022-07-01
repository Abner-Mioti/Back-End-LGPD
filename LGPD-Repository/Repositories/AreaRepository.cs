using LGPD_MDE.Entities;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository.Repositories.Generico;
using LGPD_Repository_Infra.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGPD_Repository.Repositories
{
    public class AreaRepository : RepositoryLGPD<Area>, IAreaRepository
    {
        public AreaRepository(LgpdDbContext context) : base(context)
        {

        }

    }
}
