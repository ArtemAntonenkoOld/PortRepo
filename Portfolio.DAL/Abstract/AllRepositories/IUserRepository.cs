using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.DAL.Abstract.BaseRepositories;

namespace Portfolio.DAL.Abstract.AllRepositories
{
    public interface IUserRepository : IBaseRepository<Entity.tbUser>
    {
    }
}
