using CustomerInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAlgorithms
{
    public class ValidationCustomer : IValidator<ICustomer>
    {
        public void Validate(ICustomer obj)
        {
            if (obj.CustomerName == null || obj.CustomerName.Length == 0)
            {
                throw new Exception("Customer Name is required");
            }
            if (obj.PhoneNumber == null || obj.PhoneNumber.Length == 0)
            {
                throw new Exception("Phone Number is required");
            }
            if (obj.BillAmount == 0)
            {
                throw new Exception("Bill amount is required");
            }
            if (obj.BillDate == null || obj.BillDate >= DateTime.Now)
            {
                throw new Exception("Bill date is not proper");
            }
            if (obj.Address == null || obj.Address.Length == 0)
            {
                throw new Exception("Address is not proper");
            }
        }
    }

    public class ValidationLead : IValidator<ICustomer>
    {
        public void Validate(ICustomer obj)
        {
            if (obj.CustomerName == null || obj.CustomerName.Length == 0)
            {
                throw new Exception("Customer Name is required");
            }
            if (obj.PhoneNumber == null || obj.PhoneNumber.Length == 0)
            {
                throw new Exception("Phone Number is required");
            }
        }
    }
}
