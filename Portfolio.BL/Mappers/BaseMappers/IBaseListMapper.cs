using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.BL.Mappers.BaseMappers
{
    public interface IBaseListMapper<TEntity, TUIModel> //: IBaseMapper<TEntity, TUIModel>
    {

        List<TUIModel> EntityToModel(List<TEntity> model);
        List<TEntity> ModelToEntity(List<TUIModel> model);
    }

}
