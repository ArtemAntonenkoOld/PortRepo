using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.BL.Mappers.ViewMappers;
using Portfolio.UIModels.ViewsModels;
using Portfolio.DAL.Abstract;
using Portfolio.DAL.Concrate.BaseRepositories;
using Portfolio.DAL.Concrate.AllRepositories;

namespace Portfolio.BL.BindStrategy.ViewBind
{
    public class ResumeViewBind
    {
        public List<ResumePageModel> BindFromEntities(int id)
        {
            using (RepositoryHolder scope = new RepositoryHolder())
            {
                ResumePageMapper mapper = new ResumePageMapper();

                List<ResumePageModel> result = mapper.EntityToModel(
                    scope.UserRepository
                    .FetchBy(p=>p.cId==id)

                   .ToList());
                return result;
            }

        }


        public void BindFromUIModel(ResumePageModel model)
        {
           /* using (RepositoryHolder scope = new RepositoryHolder())
            {
                ResumePageMapper mapper = new ResumePageMapper();
                var dbModel = mapper.EntityToModel(model);
                scope.UserRepository.Insert(dbModel);
                scope.SaveChanges();
            }*/
        }
    }

}
