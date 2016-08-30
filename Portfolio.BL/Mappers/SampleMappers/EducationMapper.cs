using Portfolio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.UIModels.BaseModels;
using Portfolio.BL.Mappers.BaseMappers;

namespace Portfolio.BL.Mappers.SampleMappers
{
    public class EducationMapper:IBaseListMapper<tbEducation,EducationModel>
    {
        public List<EducationModel> EntityToModel(List<tbEducation> model)
        {
            List<EducationModel> result = new List<EducationModel>();
            foreach (var item in model)
            {
                EducationModel p = new EducationModel()
                {
                   Name=item.cName,
                   Place=item.cPlace,
                   StartPeriod=item.cStartPeriod,
                   EndPeriod =item.cEndPeriod,


                };
                result.Add(p);
            };
            return result;
        }
        public List<tbEducation> ModelToEntity(List<EducationModel> model)
        {
            List<tbEducation> result = new List<tbEducation>();
            foreach (var item in model)
            {
                tbEducation p = new tbEducation()
                {


                };
                result.Add(p);
            };
            return result;
        }
    }
}
