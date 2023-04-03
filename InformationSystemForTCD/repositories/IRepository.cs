using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystemForTCD.repositories
{
    interface IRepository<T>
    {
        void Save(T model);
        void Update(T model);
        void Delete(T model);
        T GetByIdu(ulong id);
        List<T> GetAll();
    }
}
