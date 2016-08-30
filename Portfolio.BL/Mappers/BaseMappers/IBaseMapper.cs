using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.BL.Mappers.BaseMappers
{
    public interface IBaseMapper<TEntity,TUIModel>
    {
        TUIModel EntityToModel(TEntity model);
        TEntity ModelToEntity(TUIModel model);
    }
}
