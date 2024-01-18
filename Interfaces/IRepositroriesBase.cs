using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learningcore.Interfaces
{
    public interface IRepositroriesBase<T> where T:class
    {
        ICollection<T> findAll();
        T findById(int id);
        bool create(T model);
        bool update(T model);
        bool delete(T model);
        bool save();

    }
}
