using Portfolio.Entity;
using Portfolio.UIModels.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.BL.Mappers.BaseMappers;
namespace Portfolio.BL.Mappers.SampleMappers
{
    public class SkillsMapper:IBaseListMapper<tbSkills,SkillsModel>
    {
        /*
        public tbSkills EntityToModel(SkillsModel model)
        {

            tbSkills prod = new tbSkills()
            {
                cKnowledge=model.Knowledge,
                cTechnology=model.Technology
            };
            return prod;

        }
        public SkillsModel ModelToEntity(tbSkills entity)
        {
            SkillsModel pro = new SkillsModel()
            {
                Technology = entity.cTechnology,
                Knowledge = entity.cKnowledge,
                
            }; 
            return pro;
        }
        */
        public List<SkillsModel> EntityToModel(List<tbSkills> model)
        {
            List<SkillsModel> result = new List<SkillsModel>();
            foreach (var item in model)
            {
                SkillsModel p = new SkillsModel()
                {
                    Knowledge = item.cKnowledge,
                    Technology = item.cTechnology

                };
                result.Add(p);
            };
            return result;
        }
        public List<tbSkills> ModelToEntity(List<SkillsModel> model)
        {
            List<tbSkills> result = new List<tbSkills>();
            foreach(var item in model)
            {
                tbSkills pro = new tbSkills()
                {
                    cKnowledge = item.Knowledge,
                    cTechnology = item.Technology
                };
                result.Add(pro);
            };
            return result;
        }

       
    }
}
