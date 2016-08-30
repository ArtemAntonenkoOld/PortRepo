using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.Entity;
using Portfolio.DAL.Abstract.AllRepositories;

namespace Portfolio.DAL.Abstract.BaseRepositories
{
    public interface IRepositoryHolder : IDisposable

    {
        PortfolioContext Context { get; }
        IEducationRepository EducationRepository { get; }
        ILanguagesRepository LanguagesRepository { get; }
        IProjectsRepository ProjectsRepository { get; }
        ISkillsRepository SkillsRepository { get; }
        IWorkRepository WorkRepository { get; }
        
       
        void SaveChanges();
    }
}
