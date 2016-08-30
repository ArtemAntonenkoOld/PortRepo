using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.UIModels.ApiModels
{
    public class MobileWebApiAuthorizedUserModel
    {
        public int UserId { get; set; }
        public string UserPosition { get; set; }
        public byte[] UserPhoto { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public int UserAge { get; set; }
        public int UserPhone { get; set; }
        public string UserCity { get; set; }
        public string UserDesign { get; set; }
    }
}
