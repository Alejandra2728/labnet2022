using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.MVC.Logic
{
    public interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T newProduct);
        void Delete(int id);
        Task<T> Update(T products, int id);
    }
}
