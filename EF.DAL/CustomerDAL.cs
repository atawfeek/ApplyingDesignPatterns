using CommonDal;
using CustomerInterface;
using MiddleLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DAL
{
    public class CustomerDAL : AbstractDAL<CustomerBase>
    {
        public CustomerDAL(string connectionString) : base(connectionString)
        {
            
        }

        public CustomerDAL() : base()
        {

        }

        public override void Add(CustomerBase obj)
        {
            base.Add(obj);
        }

        public override List<CustomerBase> GetAll()
        {
            return base.GetAll();
        }
    }
}
