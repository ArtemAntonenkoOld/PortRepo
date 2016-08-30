using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.Entity;
using Portfolio.DAL.Abstract.BaseRepositories;


namespace Portfolio.DAL.Abstract.AllRepositories
{
    public interface IProjectsRepository: IBaseRepository<Entity.tbProjects>
    {
    }
}
