using System.Diagnostics;
using System.Linq.Expressions;

namespace _30LINQ
{
       // public delegate bool MyDelegate(int i);
        public delegate bool MyDelegate(Emp e, string pointer);
        public delegate void YourDelegate();
        public delegate T2 MyDel1<T1, T2>(T1 para1);
        public delegate Toutput MyDel1<Pinput1, Pinput2, Toutput>(Pinput1 para1, Pinput2 para2);
        public delegate Toutput MyDel1<Pinput1, Pinput2, Pinput3, Toutput>(Pinput1 para1, Pinput2 para2, Pinput3 para3);
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
                new Emp() { Id = 17, Name = "Gunjan", Address = "Pune" },
                new Emp() { Id = 18, Name = "Abhiraj", Address = "Indore" },
                new Emp() { Id = 19, Name = "Aishwarya", Address = "Kolhapur" }
            };
            MyDelegate pointer = new MyDelegate(ConditionalCheck);

            //var fileteredCollection = MyWhere(employee, pointer);
            var fileteredCollection = MyWhere(employee,
                (emp, city)
                =>
                (emp.Address.ToLower() == city.ToLower())
                );

            foreach (Emp emp in fileteredCollection)
            {
                Console.WriteLine($"{emp.Id}, {emp.Name}, {emp.Address}");
            }



        }
        public static bool Check(int i)
        {
            return i > 10;
        }
        public static List<Emp> MyWhere(IEnumerable<Emp> empList, MyDelegate pointer)
        {
            Console.WriteLine("Enter city");
            string? city = Console.ReadLine();

            List<Emp> fileteredCollection = new List<Emp>();
            foreach (Emp emp in empList)
            {
                if (pointer(emp, city))
                {
                    fileteredCollection.Add(emp);
                }
            }
            return fileteredCollection;
        }
        public static bool ConditionalCheck(Emp emp, string city)
        {
            return (emp.Address.ToLower() == city.ToLower());
        }
    }

    public class Emp
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
        }
    }
    