using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleEF.Models;

namespace SampleEF.DAL
{
    public interface IMasterClass<T>
    {
        IQueryable<T> GetAll(string keyword);
        T GetById(string Id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
}
