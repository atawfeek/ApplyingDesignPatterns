using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerInterface;

namespace MiddleLayer //Domain Layer or Business layer
{
    public class CustomerBase : ICustomer, IDisposable
    {
        private IValidator<ICustomer> _iValidator = null;

        [Key]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }

        public CustomerBase(IValidator<ICustomer> obj)
        {
            _iValidator = obj;
        }

        public CustomerBase()
        {
            
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public virtual void Validate()
        {
            _iValidator.Validate(this);
        }
    }

    //[NotMapped] Explanation:
    //Turns out that Entity Framework will assume that any class that inherits from a POCO class that is mapped to a table on the database
    //requires a Discriminator column, even if the derived class will not be saved to the DB.
    //The solution is quite simple and you just need to add[NotMapped] as an attribute of the derived class.

    [NotMapped]
    public class Customer : CustomerBase
    {
        public Customer(IValidator<ICustomer> obj) : base(obj)
        {

        }

        public Customer() : base()
        {

        }

        public override void Validate()
        {
            base.Validate();
        }
    }

    [NotMapped]
    public class Lead : CustomerBase
    {
        public Lead(IValidator<ICustomer> obj) : base(obj)
        {

        }

        public Lead() : base()
        {

        }

        public override void Validate()
        {
            base.Validate();
        }
    }
}
