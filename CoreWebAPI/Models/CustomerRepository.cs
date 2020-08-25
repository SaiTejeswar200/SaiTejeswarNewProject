using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Models
{
    public class CustomerRepository : Icustomer
    {
        private List<Customer> cus = new List<Customer>();
        public IEnumerable<Customer> create(Customer c)
        {
            //    if (cus == null )
            //    {

            //cus = new List<Customer>
            //{
            //    new Customer{Cus_ID = c.Cus_ID,Cus_Name =c.Cus_Name , order_cost = c.order_cost},
            //};
            
            cus.Add(c);
            //}
            return cus;
        }

        public IEnumerable<Customer> delete(int id)
        {
            foreach (Customer item in cus.ToList())
            {
                if (item.Cus_ID == id)
                {
                    cus.Remove(item);
                }
            }
            return cus;
        }

        public Customer getbyid(int id)
        {
            Customer tempc = new Customer();
            foreach (Customer item in cus)
            {
                if (item.Cus_ID == id)
                {
                    //tempc = new Customer { Cus_ID = item.Cus_ID, Cus_Name = item.Cus_Name, order_cost = item.order_cost };
                    return item;
                }
            }
            return tempc;
            
        }
    }
}
