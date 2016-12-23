using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDemo.Models
{
    /// <summary>
    /// IArticleRepository接口
    /// </summary>
    public interface IArticleRepository
    {
        IEnumerable<Article> GetAll();
        Article Get(int id);
        Article Add(Article item);
        bool Update(Article item);
        bool Delete(int id);
    }
}
