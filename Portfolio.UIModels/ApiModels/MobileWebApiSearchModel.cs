using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.UIModels.ApiModels
{
    public class MobileWebApiSearchModel
    {
        public int UserId { get; set; }
        public string UserPosition { get; set; }
        public byte[] UserPhoto { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
    }
}
