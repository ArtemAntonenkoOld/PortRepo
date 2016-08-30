using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.BL.Mappers.BaseMappers;
using Portfolio.UIModels.BaseModels;
using Portfolio.Entity;

namespace Portfolio.BL.Mappers.SampleMappers
{
    public class WorkMapper:IBaseListMapper<tbWork,WorkModel>
    {
        public List<tbWork> ModelToEntity(List<WorkModel> model)
        {
            List<tbWork> result = new List<tbWork>();
            foreach (var item in model)
            {
                tbWork pro = new tbWork()
                {
                   
                    cCompany=item.Company,
                    cStanding =item.Standing,
                    cStartPeriod = item.StartPeriod,
                    cEndPeriod = item.EndPeriod
                    
                };
                result.Add(pro);
            };
            return result;
        }
        public List<WorkModel> EntityToModel(List<tbWork> model)
        {
            List<WorkModel> result = new List<WorkModel>();
            foreach (var item in model)
            {
                WorkModel pro = new WorkModel()
                {

                    Company = item.cCompany,
                    Standing = item.cStanding,
                    StartPeriod = item.cStartPeriod,
                    EndPeriod = item.cEndPeriod

                };
                result.Add(pro);
            };
            return result;
        }

    }
}
