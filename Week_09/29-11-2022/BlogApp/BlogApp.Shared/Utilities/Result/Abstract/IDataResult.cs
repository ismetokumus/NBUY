using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Utilities.Result.Abstract
{
    //ref out araştır.
    public interface IDataResult<out T> : IResult
    {
        public T Data { get; } 
        // new DataResult<Category>(ResultStatus.Success, category)
        //new DataResult<IList<Category>>(ResulStatus.Success,
    }
}
