using CustomerInterface;
using InterfaceDal;
using MiddleLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDal
{
    public class AbstractDAL<AnyType> : IRepository<AnyType>
        where AnyType : class
    {
        private DbContext dbcontext = null;
        private string _connectionString;
        public AbstractDAL(string connectionString)
        {
            dbcontext = new Uow(connectionString);  //self contained transaction
            _connectionString = connectionString;
        }

        //protected List<AnyType> objects = new List<AnyType>(); //no need to create in-memory list where EF already handles In-Memory

        public virtual void Add(AnyType obj)
        {
            dbcontext.Set<AnyType>().Add(obj); //In-Memory
        }
         
        public virtual void Save(AnyType obj)
        {
            dbcontext.SaveChanges();
        }

        public virtual List<AnyType> Search(AnyType obj)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(AnyType obj)
        {
            throw new NotImplementedException();
        }

        public virtual List<AnyType> GetAll()
        {
            var custs = dbcontext.Set<AnyType>()
                    .ToList();

            return custs;
        }

        public void SetUnitOfWork(IUow IUow)
        {
            dbcontext = ((Uow)IUow);  //Global transaction
        }
    }
}
