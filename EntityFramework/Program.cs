using EntityFramework.DAL;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DacDBContext dbCnotext = new DacDBContext();

            while (true)
            {
                Console.WriteLine("Enter operation choice 1. Select, 2. Insert, 3.Update, 4.Delete" +
                     " 5. Get Employee by Id using SP, 6. Get All Employess based on Address start Letter");
                int opChoice = Convert.ToInt32(Console.ReadLine());
                switch (opChoice)
                {
                    case 1:
                        {
                            var allEmployees = dbCnotext.employees.ToList();
                            foreach (var emp in allEmployees)
                            {
                                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Address: {emp.Address}");
                            }
                        }
                        break;

                    case 2:
                        {
                            Employee eInsert = new Employee();
                            Console.WriteLine("Enter the Name");
                            eInsert.Name = Console.ReadLine();
                            Console.WriteLine("Enter the Address");
                            eInsert.Address = Console.ReadLine();

                            dbCnotext.employees.Add(eInsert);
                            dbCnotext.SaveChanges();
                        }
                        break;
                    case 3:

                        {
                            Console.WriteLine("Enter th Id");
                            int id = Convert.ToInt32(Console.ReadLine());

                            Employee eupdate = dbCnotext.employees.Find(id);
                            Console.WriteLine("Enter the Name");
                            eupdate.Name = Console.ReadLine();
                            Console.WriteLine("Enter the Address");
                            eupdate.Address = Console.ReadLine();

                            dbCnotext.SaveChanges();

                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter the Id");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Employee edelete = dbCnotext.employees.Find(id);

                            dbCnotext.employees.Remove(edelete);
                            dbCnotext.SaveChanges();

                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Enter the Id");
                            int idSearched = Convert.ToInt32(Console.ReadLine());
                            Employee empById = dbCnotext.GetEmployeeById(idSearched);
                            Console.WriteLine("Id:{empById.Id},Name:{empBy.Name},Address:{empById.Address}");
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Enter first letter of address for Employee to be searched");
                            string? cityStartLetter = Console.ReadLine().ToUpper();
                            var emps = dbCnotext.GetEmployeesByAddressStartWith(cityStartLetter);

                            foreach (var emp in emps)
                            {
                                Console.WriteLine($"Id:{emp.Id},Name:{emp.Name},Address:{emp.Address}");

                            }

                        }
                        break;
                    default:

                        Console.WriteLine("Onvalid Choice");
                        break;
                }
                Console.WriteLine("Do you want to continue? y/n");
                string? ynChoice = Console.ReadLine();
                if (ynChoice == "n")
                {
                    break;
                }
            }
        }
    }
}
