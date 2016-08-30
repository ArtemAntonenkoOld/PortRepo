using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.DAL.Abstract.BaseRepositories;
using Portfolio.DAL.Abstract.AllRepositories;

namespace Portfolio.DAL.Concrate.AllRepositories
{
    public class EducationRepository : GenericRepository<Entity.tbEducation>, IEducationRepository
    {
        public EducationRepository(Entity.PortfolioContext context)
            : base(context)
        {

        }
    }
}
