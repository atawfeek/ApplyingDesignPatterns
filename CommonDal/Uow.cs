using CustomerInterface;
using MiddleLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDal
{
    public class Uow : DbContext, IUow
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Mapping
            modelBuilder.Entity<CustomerBase>().ToTable("Customers");
        }

        private string _connectionString;
        public Uow(string connectionString) : base("name=Conn")
        {
            _connectionString = connectionString;
        }

        public void Committ()
        {
            SaveChanges();
        }

        public void Rollback() //Adapter patter because we're adapting two incompatible interfaces
        {
            Dispose();
        }
    }
}
