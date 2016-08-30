using Portfolio.UIModels.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.Entity;
using Portfolio.UIModels.ViewsModels;
using Portfolio.BL.Mappers.BaseMappers;
using Portfolio.BL.Mappers.SampleMappers;

namespace Portfolio.BL.Mappers.ViewMappers
{

    public class ResumePageMapper : IBaseListMapper<tbUser, ResumePageModel>
    {
        public List<ResumePageModel> EntityToModel(List<tbUser> model)
        {
            SkillsMapper _skillsMapper = new SkillsMapper();
            LanguagesMapper _languagesMapper = new LanguagesMapper();
            WorkMapper _workMapper = new WorkMapper();
            EducationMapper _educationMapper = new EducationMapper();

            List<ResumePageModel> result = new List<ResumePageModel>();
            foreach (var item in model)
            {
                ResumePageModel p = new ResumePageModel()
                {
                    UserName = item.cName,
                    UserId = item.cId,
                    UserAge = item.cAge,
                    UserEmail = item.cEmail,
                    UserPhone = item.cPhone,
                    UserPosition = item.cPosition,
                    UserSurname = item.cSurname,
                    Design = item.cDesign,
                    UserDescription = item.cDescription,
                    UserCity = item.cCity,
                    UserPhoto = item.cPhoto,
                    LanguagesModel = _languagesMapper.EntityToModel(item.tbLanguages.ToList()),
                    SkillsModel = _skillsMapper.EntityToModel(item.tbSkills.ToList()),
                    WorkModel = _workMapper.EntityToModel(item.tbWork.ToList()),
                    EducationModel = _educationMapper.EntityToModel(item.tbEducation.ToList())

                };
                result.Add(p);
            }
            return result;
        }
        public List<tbUser> ModelToEntity(List<ResumePageModel> model)
        {
            SkillsMapper _skillsMapper = new SkillsMapper();
            LanguagesMapper _languagesMapper = new LanguagesMapper();
            WorkMapper _workMapper = new WorkMapper();
            List<tbUser> result = new List<tbUser>();
            foreach (var item in model)
            {
                tbUser p = new tbUser()
                {


                };
                result.Add(p);
            }
            return result;
        }
       
    }

}
