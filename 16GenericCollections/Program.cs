using System.Collections.Generic;
namespace _16GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Customer cust1 = new Customer();
            cust1.Id = 1;
            cust1.Name = "Rohit";
            cust1.Address = "Nanded";
            Customer cust2 = new Customer();
            cust2.Id = 2;
            cust2.Name = "Roshan";
            cust2.Address = "Gadchiroli";
            Customer cust3 = new Customer();
            cust3.Id = 3;
            cust3.Name = "Ketan";
            cust3.Address = "Mumbai";

            Dictionary<int, Customer> dt = new Dictionary<int, Customer>();
            dt.Add(1, cust1);
            dt.Add(2, cust2);
            dt.Add(3, cust3);
            foreach (var key in dt.Keys)
            {
                Customer cust = dt[key];
                Console.WriteLine($"Id: {dt[key].Id}, Name: {cust.Name}, Address: {cust.Address}");
            }
        }
    }
    public class Customer
    {
        private int _Id;
        private string _Name;
        private string _Address;
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

    }
}
