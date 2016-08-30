using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.UIModels.BaseModels;


namespace Portfolio.UIModels.ViewsModels
{
    public class ResumePageModel
    {
        public int UserId{ get; set; }
        public string UserName{ get; set; }
        public string UserSurname{ get; set; }
        public string UserEmail{ get; set; }
        public string UserPosition { get; set; }
        public int UserAge { get; set; }
        public int UserPhone { get; set; }
        public string Design { get; set; }
        public string UserDescription { get; set; }
        public string UserCity { get; set; }
        public byte[] UserPhoto { get; set; }
        public List<WorkModel> WorkModel { get; set; }
        public List<EducationModel> EducationModel { get; set; }
        public List<SkillsModel> SkillsModel { get; set; }
        public List<LanguagesModel> LanguagesModel { get; set; }
    }
}
