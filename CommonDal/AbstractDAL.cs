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
    public abstract class AbstractDAL<AnyType> : DbContext , IDAL<AnyType>
        where AnyType : class
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Mapping
            modelBuilder.Entity<CustomerBase>().ToTable("Customers");
        }
        protected string _connectionString = "";
        public AbstractDAL(string ConnectionString)
            : base("name=conn")
        {
            _connectionString = ConnectionString;
        }

        public AbstractDAL()
        {
            
        }

        //protected List<AnyType> objects = new List<AnyType>(); //no need to create in-memory list where EF already handles In-Memory

        public virtual void Add(AnyType obj)
        {
            Set<AnyType>().Add(obj); //In-Memory
        }
         
        public virtual void Save(AnyType obj)
        {
            SaveChanges();
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
            var custs = Set<AnyType>()
                    .ToList();

            return custs;
        }
    }
}
