using System;

namespace _5_6LabSolution
{
    class Program
    {

        public struct Customer
        {
            public string first_name;
            public string last_name;
            public int age;
            public bool hasMembership;
        }

        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            customer1.first_name = "Victor";
            customer1.last_name = "Arellano";
            customer1.age = 17;
            customer1.hasMembership = false;

            customer2.first_name = "Enrique";
            customer2.last_name = "Cantu";
            customer2.age = 31;
            customer2.hasMembership = false;

            customer3.first_name = "Sam";
            customer3.last_name = "Mata";
            customer3.age = 25;
            customer3.hasMembership = true;

            Customer[] allCustomers = { customer1, customer2, customer3 };

            for (int i = 0; i < allCustomers.Length; i++)
            {
                if (allCustomers[i].age < 21)
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " is not allowed to place an order");
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
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " is a standard member.");
                }




            }



        }
    }
}