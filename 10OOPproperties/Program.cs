namespace _10OOPproperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            string deptname = emp.Dept;
            Console.WriteLine(deptname);

        }
    }
    public class Employee
    {
        private int _EID;
        private string _EName;
        private logger _logger;
        private string _Dept;

        public int EId
        {
            set
            {
                _EID = value;
            }
            get
            {
                return _EID;
            }
        }
        public string EName
        {
            set
            {
                _EName = value;
            }
            get
            {
                _EName = "Mr." + _EName;
                return _EName;
            }
        }

        public logger logger

        {
            set
            {
                _logger = value;
            }
            get
            {
                return _logger;
            }
        }
        public string Dept
        {
            get
            {
                _Dept = "HR";
                return _Dept;
            }
        }
    }
    public class logger
    {
        public void log()
        {
            Console.WriteLine("Logger method output");
                }
    }
}