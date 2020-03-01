using System;

namespace ConsoleApp5_6
{
    class Program
    {
        struct Customer
        {
            
            public string first_name;
            public string last_name;
            public int age;
            public bool hasMembership;


        }
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.first_name = "Brian";
            customer1.last_name = "O'Brien";
            customer1.age = 18;
            customer1.hasMembership = false;

            Customer customer2 = new Customer();
            customer2.first_name = "Jessica";
            customer2.last_name = "Haase";
            customer2.age = 30;
            customer2.hasMembership = false;

            Customer customer3 = new Customer();
            customer3.first_name = "Frank";
            customer3.last_name = "Bank";
            customer3.age = 82;
            customer3.hasMembership = true;


            Customer[] allCustomers = { customer1, customer2, customer3 };
            
            for (int i = 0; i <allCustomers.Length; i++)
            {
                if (allCustomers[i].age < 21)
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i] + " is not allowed to place an order");
                   
                }
                else
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " can place an order");

                }
                if (allCustomers[i].hasMembership == true)
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " is a premium member.");

                }
                else
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " is not a premium member.");
                }
            }


            

        }
    }
}
