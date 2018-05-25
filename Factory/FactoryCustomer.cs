using MiddleLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Unity;
using CustomerInterface;
using Unity.Injection;
using ValidationAlgorithms;
using EF.DAL;
using InterfaceDal;

namespace Factory
{
    public class FactoryCustomer
    {
        //private static Dictionary<string, CustomerBase> customers = new Dictionary<string, CustomerBase>();
        private static IUnityContainer customersContainer = null; //dependancy injection replaces simple factory pattern

        public static ICustomer Create(string custType)
        {
            if (customersContainer == null) //lazy loading design pattern
            {
                customersContainer = new UnityContainer();

                customersContainer.RegisterType<ICustomer, Customer>("Customer"
                    , new InjectionConstructor(new ValidationCustomer())
                    );
                customersContainer.RegisterType<ICustomer, Lead>("Lead"
                     , new InjectionConstructor(new ValidationLead())
                     );

                //customers.Add("Customer", new Customer());
                //customers.Add("Lead", new Lead());
            }

            //return customers[custType]; //Polymorphism design pattern
            return customersContainer.Resolve<ICustomer>(custType);
        }

        public static IDAL<CustomerBase> CreateDAL(string custType)
        {
            if (customersContainer == null) //lazy loading design pattern
            {
                customersContainer = new UnityContainer();

                customersContainer.RegisterType<IDAL<CustomerBase>, CustomerDAL>("CustomerDAL"
                    , new InjectionConstructor("Data Source=.;Initial Catalog=Customers;User ID=sa;Password=Windows.2000;Integrated Security=True")
                     );

                //customers.Add("Customer", new Customer());
                //customers.Add("Lead", new Lead());
            }

            //return customers[custType]; //Polymorphism design pattern
            return customersContainer.Resolve<IDAL<CustomerBase>>(custType);
        }
    }
}
