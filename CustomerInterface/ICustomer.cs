using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInterface
{
    // *** Generic interfaces is best practice to achieve physical loosely coupled UI and business logic layers

    public interface ICustomer
    {
        string CustomerName { get; set; }
        string PhoneNumber { get; set; }
        decimal BillAmount { get; set; }
        DateTime BillDate { get; set; }
        string Address { get; set; }

        void Validate();
    }

    public interface IValidator<AnyType> //generic interface : strategy Pattern 
        //it's a behavioral design pattern which helps to select algorithms on runtime.
    {
        void Validate(AnyType obj);
    }
}
