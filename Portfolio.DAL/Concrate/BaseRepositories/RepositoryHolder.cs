using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.DAL.Abstract.BaseRepositories;
using Portfolio.DAL.Abstract.AllRepositories;
using Portfolio.DAL.Concrate.AllRepositories;
using Portfolio.Entity;

namespace Portfolio.DAL.Concrate.BaseRepositories
{
    public class RepositoryHolder: IRepositoryHolder
    {
        Entity.PortfolioContext _context;
        IWorkRepository _workRepository;
        ISkillsRepository _skillsRepository;
        IProjectsRepository _projectRepository;
        ILanguagesRepository _languagesRepository;
        IEducationRepository _educationRepository;
        IUserRepository _userRepository;
        public RepositoryHolder()
        {
            _context = new Entity.PortfolioContext();
        }
        public Entity.PortfolioContext Context
        {
            get
            {
                return _context;
            }

        }
        public IWorkRepository WorkRepository
        {
            get
            {
                if (_workRepository == null)
                    _workRepository = new WorkRepository(_context);
                return _workRepository;
            }
        }
        public ISkillsRepository SkillsRepository
        {
            get
            {
                if (_skillsRepository == null)
                    _skillsRepository = new SkillsRepository(_context);
                return _skillsRepository;
            }
        }
        public IProjectsRepository ProjectsRepository
        {
            get
            {
                if (_projectRepository == null)
                    _projectRepository = new ProjectsRepository(_context);
                return _projectRepository;
            }
        }
        public ILanguagesRepository LanguagesRepository
        {
            get
            {
                if (_languagesRepository == null)
                    _languagesRepository = new LanguagesRepository(_context);
                return _languagesRepository;
            }
        }
        public IEducationRepository EducationRepository
        {
            get
            {
                if (_educationRepository == null)
                    _educationRepository = new EducationRepository(_context);
                return _educationRepository;
            }
        }
        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_context);
                return _userRepository;
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            if (_workRepository != null)
            {
                _workRepository.Dispose();
            }
            if (_skillsRepository != null)
            {
                _skillsRepository.Dispose();
            }
            if (_projectRepository != null)
            {
                _projectRepository.Dispose();
            }
            if (_languagesRepository != null)
            {
                _languagesRepository.Dispose();
            }
            if (_educationRepository != null)
            {
                _educationRepository.Dispose();
            }
            if (_userRepository != null)
            {
                _userRepository.Dispose();
            }
        }
    }
}
