namespace _12Delegate
{
    public delegate void MyDlegate();
    public delegate void MyDelegate1(string str);
    public delegate string MyDelegate2();

    internal class Program
    {
        static void Main(string[] args)
        {
           AnualFunction obj = new AnualFunction();
            MyDlegate del = new MyDlegate(obj.Func1);
            del += obj.Func2; 
            del += obj.Func3;
            Console.WriteLine("should we Procced for celebrity");
            bool isProceed = Convert.ToBoolean(Console.ReadLine());
            if (isProceed)
            {
                del -= obj.Func3; 
            }

            del();
            Console.WriteLine("after some time");
            MyDlegate del2 = new MyDlegate(obj.Func4);
            del2();

            MyDelegate2 delObj = new MyDelegate2(obj.Func5);
            string msg = delObj();
            Console.WriteLine(msg);
        }
        public static void SayHi()
        {
            Console.WriteLine("Hello!");
        }
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }
    }
    public class AnualFunction
    {
        public void Func1()
        {
            Console.WriteLine("Wel-come speech");
        }
        public void Func2()
        {
            Console.WriteLine("Guests speech");
        }
        public void Func3()
        {
            Console.WriteLine("Invite all for dinner party");
        }
        public void Func4()
        {
            Console.WriteLine("Pack up!");
        }
        public string Func5()
        {
            return "Bye!Good Night everyone !";
        }
    }
}

