namespace _13Event
{
    public delegate void ResultDelegate(int i);
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            ResultDelegate resultpass = new ResultDelegate(student.OnSuccess);
            student.Pass += resultpass;

            ResultDelegate resultfail = new ResultDelegate(student.OnFailure);
            student.Fail += resultfail;

            Console.WriteLine("Enter the Marks");
            student.Marks=Convert.ToInt32(Console.ReadLine());

        
        
        }
    }

    public class Student
    {
        public event ResultDelegate Pass;
        public event ResultDelegate Fail;

        private int _Marks;

        public int Marks
        {
            get
            {
                return _Marks;

            }
            set { _Marks = value;
                if (_Marks > 35)
                {
                    Pass(_Marks);
                }
                else
                {
                    Fail(_Marks);
                }
            }
        }

        public void OnSuccess(int marks)
        {
            Console.WriteLine("Congratulation!! you passes with {0} marks", marks);
        }
        public void OnFailure(int marks)
        {
            Console.WriteLine("Congratulation!! you fail with {0} marks", marks);
        }


    }
}

