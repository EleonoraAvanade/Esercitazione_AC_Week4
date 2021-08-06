using System;
using System.Collections.Generic;

namespace CoreLayer.Repositories
{
    public interface IRepository<T>
    {
        List<T> Read();
        T GetById(int id);
        bool Add(T item);
        bool Update(T item);
        bool Delete(T item);
    }
}
