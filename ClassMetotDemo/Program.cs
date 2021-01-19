using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Id = 1,
                name = "Emre",
                LastName = "Şener",

            };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(customer);
            musteriManager.list(customer);
            musteriManager.Sil(customer);
        }
    }


    class Customer
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string LastName { get; set; }



    }

    class MusteriManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(" ( " + customer.Id + " - " + customer.name + " " + customer.LastName + " ) " + " müşteri eklendi");
        }

        public void list(Customer customer)
        {
            Console.WriteLine(customer.name + " " + customer.LastName + " Listelendi.");
        }

        public void Sil(Customer customer)
        {
            Console.WriteLine(customer.name + " " + customer.LastName + " Silimdi.");
        }

    }

}
