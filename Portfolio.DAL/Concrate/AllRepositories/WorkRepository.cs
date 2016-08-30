using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.DAL.Abstract.BaseRepositories;
using Portfolio.DAL.Abstract.AllRepositories;

namespace Portfolio.DAL.Concrate.AllRepositories
{
    public class WorkRepository : GenericRepository<Entity.tbWork>, IWorkRepository
    {
        public WorkRepository(Entity.PortfolioContext context)
            : base(context)
        {

        }
    }
}
