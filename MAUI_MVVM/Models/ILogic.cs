using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_MVVM.Models
{
    public interface ILogic<T, in TPk> where T : class
    {
        IEnumerable<T> GetAsync();
        T GetAsync(TPk criteria);
        IEnumerable<T> Create(T entity);
    }
}
