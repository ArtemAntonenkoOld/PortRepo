using Portfolio.BL.Mappers.ApiMappers;
using Portfolio.DAL.Concrate.BaseRepositories;
using Portfolio.UIModels.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.BL.BindStrategy.ApiBind
{
    public class MobileWebApiAuthorizedUserBind
    {
        public List<MobileWebApiAuthorizedUserModel> BindData()
        {
            RepositoryHolder holder = new RepositoryHolder();

            MobileWebApiAuthorisedUserMapper mapper = new MobileWebApiAuthorisedUserMapper();
            var _userRepository = holder.UserRepository;
            List<MobileWebApiAuthorizedUserModel> resultnewData =
                _userRepository.
                    Fetch().
                    Select(p => mapper.EntityToModel(p)).
                    ToList();

            return resultnewData;
        }
    }
}
