using Portfolio.UIModels.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.Entity;
using Portfolio.BL.Mappers.BaseMappers;

namespace Portfolio.BL.Mappers.SampleMappers
{
    public class LanguagesMapper:IBaseListMapper<tbLanguages,LanguagesModel>
    {
        /*
        public tbLanguages EntityToModel(LanguagesModel model)
        {

            tbLanguages prod = new tbLanguages()
            {
               cLanguage=model.cLanguage
            };
            return prod;

        }

        public LanguagesModel ModelToEntity(tbLanguages entity)
        {
            LanguagesModel pro = new LanguagesModel()
            {
                cLanguage=entity.cLanguage
            };
            return pro;
        }*/

        public List<LanguagesModel> EntityToModel(List<tbLanguages> model)
        {
            List<LanguagesModel> result = new List<LanguagesModel>();
            foreach (var item in model)
            {
                LanguagesModel p = new LanguagesModel()
                {
                    Language=item.cLanguage,
                    Level=item.cLevel

                };
                result.Add(p);
            };
            return result;
        }
        public List<tbLanguages> ModelToEntity(List<LanguagesModel> model)
        {
            List<tbLanguages> result = new List<tbLanguages>();
            foreach (var item in model)
            {
                tbLanguages pro = new tbLanguages()
                {
                    cLevel =item.Level,
                    cLanguage = item.Language
                };
                result.Add(pro);
            };
            return result;
        }
    }
}
