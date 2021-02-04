using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Added.");
        }

        public void List (Customer customer)
        {
            Console.WriteLine("ID: " + customer.Id + ", Name: " + customer.Name + ", Surname: " + customer.Surname + ", City: " + customer.City);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Deleted!");
        }
        

    }
}
