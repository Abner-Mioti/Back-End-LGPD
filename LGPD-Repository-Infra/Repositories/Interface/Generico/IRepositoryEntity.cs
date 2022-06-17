using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGPD_Repository_Infra.Repositories.Interface.Generico
{
    public interface IRepositoryEntity<TEntity> : IRepository<TEntity> where TEntity : class
    {
    }
}
