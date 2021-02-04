using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Ensar";
            customer1.Surname = "Uç";
            customer1.City = "Antalya";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Furkan";
            customer2.Surname = "Gökçe";
            customer2.City = "İstanbul";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Yasemin";
            customer3.Surname = "Ballı";
            customer3.City = "Ankara";


            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Add(customer1);
            customerManager1.List(customer1);
            customerManager1.Delete(customer1);

            CustomerManager customerManager2 = new CustomerManager();
            customerManager2.Add(customer2);
            customerManager2.List(customer2);
            customerManager2.Delete(customer2);

            CustomerManager customerManager3 = new CustomerManager();
            customerManager3.Add(customer3);
            customerManager3.List(customer3);
            customerManager3.Delete(customer3);


            Console.ReadKey();
        }
    }
}
