using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.UIModels.BaseModels
{
    public class UserModel
    {
        public int cId { get; set; }
        public string cName { get; set; }
        public string cSurname { get; set; }
        public string cEmail { get; set; }
        public string cPosition { get; set; }
        public string cDescription { get; set; }
        public int? cAge { get; set; }
        public int? cPhone { get; set; }
        public string cCity { get; set; }
        public string cDesign { get; set; }
        public  List<WorkModel> Work { get; set; }
        public List<SkillsModel> Skills { get; set; }
        public List<ProjectsModel> Projects { get; set; }
        public List<LanguagesModel> Languages { get; set; }
        public List<EducationModel> Education { get; set; }
    }
}
