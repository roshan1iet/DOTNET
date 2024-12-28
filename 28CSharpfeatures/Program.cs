using System.Security.Cryptography.X509Certificates;

namespace _28CSharpfeatures
{
    //public delegate bool MyDelegate(int x);
    public delegate bool Predicate<in T>(T obj);
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Partial Class
            // CMath obj = new CMath();

            //Console.WriteLine($"Add={obj.add(10, 20)}");
            //Console.WriteLine($"Sub={obj.Sub(20, 10)}");

            //obj.fruit(); 
            #endregion
            #region Nullable Type



            // int? i = null;
            // int? i = 10;
            // Nullable<int> i = null;
            // if (i.HasValue)
            // {
            //     Console.WriteLine($"Value of i = {i}");
            // }
            // else
            // {
            //     Console.WriteLine("Value of i =null");
            // }

            // if (i == null)
            // {
            //     Console.WriteLine("Value of i = null");
            // }

            // Emp obj = new Emp();
            // obj.Id = 3;
            // obj.Name = "Rohit";
            // obj.Sal = null;
            // obj.Dept = "IT";
            #endregion

            //Console.WriteLine("Enter the value");
            //int input = Convert.ToInt32(Console.ReadLine());
            //bool result = Check(input);
            //Console.WriteLine($"{input} is greater than 10 = {result}");


            #region MyDelegate Method
            //Console.WriteLine("Enter the value");
            //int input = Convert.ToInt32(Console.ReadLine());
            //MyDelegate del = new MyDelegate(Check);
            //bool result=del(input);
            //Console.WriteLine($"{input} is greater than 10 = {result}");
            #endregion


            #region Delegate again
            //Console.WriteLine(" Enter a  value ");
            //int input = Convert.ToInt32(Console.ReadLine());


            //MyDelegate del = delegate (int i)
            //{
            //    return i > 10;
            //};
            //bool result = del(input);

            //Console.WriteLine($" {input} is greater than 10 = {result}");

            #endregion

            #region Lambda Expression
            //Console.WriteLine("Enter the value");
            //int input = Convert.ToInt32(Console.ReadLine());
            ////MyDelegate del = (i) =>
            ////{
            ////    return i > 10;
            ////};

            //MyDelegate del = i => i > 10;
            //bool result = del(input);
            //Console.WriteLine($" {input} is greater than 10 = {result}"); 
            #endregion

            

        Console.WriteLine("Enter a value ");
        int input = Convert.ToInt32(Console.ReadLine());

        Predicate<int> pointer = i => i > 10;
        bool result = pointer(input);

        Console.WriteLine($" {input} is greater than 10 = {result}"); 

       
       }

    //public static bool Check(int i)
    //{
    //    return i > 10;
    //}
    }

    public class Emp
    {
        private int _Id;
        private string _Name;
        private string _Dept;
        //private double? _Sal;
        private Nullable<double> _Sal;

        public double? Sal
        {
            get { return _Sal; }
            set
            {
                _Sal = value;
                //_Sal.HasValue = true;
            }
        }
        public string Dept
        {
            get { return _Dept; }
            set { _Dept = value; }
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


    