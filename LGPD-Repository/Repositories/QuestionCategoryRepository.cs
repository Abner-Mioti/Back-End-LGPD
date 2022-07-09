using LGPD_MDE.Entities;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository.Repositories.Generico;
using LGPD_Repository_Infra.Repositories.Interface;

namespace LGPD_Repository.Repositories
{
    public class QuestionCategoryRepository : RepositoryLGPD<QuestionCategory>, IQuestionCategoryRepository
    {
        public QuestionCategoryRepository(LgpdDbContext context) : base(context)
        {

        }

    }
}
