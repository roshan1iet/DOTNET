using System.ComponentModel.Design;

namespace _29LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emp> employee = new List<Emp>()
            {

                new Emp() { Id = 11, Name = "Ganesh", Address = "Pune" },
                new Emp() { Id = 12, Name = "Gajanan", Address = "Punjab" },
                new Emp() { Id = 13, Name = "Divyansh", Address = "Mumbai" },
                new Emp() { Id = 14, Name = "Anup", Address = "Pune" },
                new Emp() { Id = 15, Name = "Deepali", Address = "Patna" },
                new Emp() { Id = 16, Name = "Aman", Address = "Manipur" },
            };
            #region Normal conditinal based filterartion and loops from a collection


            //Console.WriteLine("Enter the name of city");
            //string city = Console.ReadLine();

            //var FilteredCollection = new List<Emp>();
            //foreach (Emp emp in employee)
            //{
            //    if (emp.Address.ToLower() == city.ToLower())
            //    {
            //        FilteredCollection.Add(emp);
            //    }
            //}
            //foreach (Emp emp in FilteredCollection)
            //{
            //    Console.WriteLine($"Id={emp.Id}, Name={emp.Name}, Address={emp.Address}");         }
            #endregion

            #region MyRegion
            //select * from Emp;
            //"Select * from Emp where Address='Pune'"

            //IEnumerable<Emp> FilteredCollection = (from emp in employee 
            //                                       select emp);
            //    Console.WriteLine("Enter name of city : ");
            //    string city = Console.ReadLine();
            //    IEnumerable<Emp> FilteredCollection = (from emp in employee
            //                                           //where emp.Address.ToLower() == city.ToLower()
            //                                           select emp);

            //    foreach (Emp emp in FilteredCollection)
            //    {
            //        Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");

            //    } 
            #endregion

            #region MyRegion
            //IEnumerable<Emp> FilteredCollection = (from emp in employee
            //                                       select emp);
            //Console.WriteLine("Enter name of city :");
            //string city = Console.ReadLine();
            //IEnumerable<Emp> FilteredCollection = (from emp in employee
            //                                       where emp.Address.ToLower() == city.ToLower()
            //                                       select emp);  //ToList(); //.ToList() 

            ////var FilteredCollection = (from emp in employee
            ////                          where emp.Address.ToLower() == city.ToLower()
            ////                          select emp);
            //employee.Add(new Emp() { Id = 20, Name = "Amit", Address = "Pune" });
            //employee.Add(new Emp() { Id = 21, Name = "Neha", Address = "Kolhapur" });
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Filtered collection based on {0} city: \n", city);
            //// foreach (Emp emp in FilteredCollection) //Foreach is firing Query on LINQ

            //foreach (Emp emp in FilteredCollection)
            //{
            //    Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");
            //}

            #endregion

            #region MyRegion
            //Console.WriteLine("Enter name of city :");
            //string? city = Console.ReadLine();

            //var FilteredCollection = (from emp in employee
            //                          where emp.Address.ToLower() == city.ToLower()
            //                          select emp.Name).ToList();


            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Filtered collection based on {0} city: \n", city);
            //foreach (var name in FilteredCollection)
            //{
            //    //Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");
            //    Console.WriteLine($"Name = {name}");
            //} 

            //foreach (Emp emp in FilteredCollection)
            //{
            //    //Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");
            //    Console.WriteLine($"Name = {emp.Name}, Address = {emp.Address}");
            //} 
            #endregion

            Console.WriteLine("Enter name of city :");
            string? city = Console.ReadLine();

            var FilteredCollection = (from emp in employee
                                      where emp.Address.ToLower() == city.ToLower()
                                      select new { nm = emp.Name, add = emp.Address })
                                      .ToList();


            Console.WriteLine("---------------------------------");
            Console.WriteLine("Filtered collection based on {0} city: \n", city);

            foreach (var obj in FilteredCollection)
            {
                //Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");
                Console.WriteLine($"Name = {obj.nm}, Address = {obj.add}");
            }
            

            #region MyRegion
            //Console.WriteLine("Enter name of city :");
            //string? city = Console.ReadLine();

            //var FilteredCollection = (from emp in employee
            //                          where emp.Address.ToLower() == city.ToLower()
            //                          select new Holder()
            //                          { HName = emp.Name, HAddress = emp.Address })
            //                         .ToList();


            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Filtered collection based on {0} city: \n", city);
            //foreach (var emp in employee)
            //{
            //    List<Holder> objlist = new List<Holder>();

            //    objlist.Add(new Holder() { HName = emp.Name, HAddress = emp.Address });
            //}
            ////foreach (Holder obj in FilteredCollection)
            ////{
            ////    Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");
            ////    Console.WriteLine($"Name = {obj.HName}, Address = {obj.HAddress}");
            ////} 
            #endregion

        }
        public class Holder
        {
            public int HId { get; set; }
            public string HName { get; set; }
            public string HAddress { get; set; }
        }
        public class Emp
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
        }
    }
}