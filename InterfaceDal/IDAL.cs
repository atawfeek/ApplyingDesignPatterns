using CustomerInterface;
using MiddleLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDal
{
    // Design Pattern :- Repository pattern

    public interface IDAL<AnyType>
    {
        void Add(AnyType obj); //InMemory Addition
        void Update(AnyType obj); //InMemory Updation
        List<AnyType> Search(AnyType obj);
        void Save(AnyType obj); //Physicl committ
        List<AnyType> GetAll();
    }
}
