using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystemForTCD.repositories
{
    interface IRepository<T>
    {
        public void Save(T model);
        public void Update(T model);
        public void Delete(T model);
        public T GetById(int id);
        public List<T> GetAll();
    }
}
