namespace Inheritence
{

    class Test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Rohit rohi = new Rohit();
            rohi.Speak();

            Roshan rosh = new Roshan();
            rosh.write();



        }
    }
}




class Person
    {
        public Person()
        {
            Console.WriteLine("in default base Constructor");
        }

        public void Speak()
        {
            Console.WriteLine("i am good in speaking");
        }

    }

    class Rohit : Person
    {
        public Rohit()
        {
            Console.WriteLine("default rohit");
        }

        public void speak()
        {
            Console.WriteLine("Rohit is Speaking");
        }
    }

    class Roshan : Person
    {
        public Roshan()
        {
            Console.WriteLine("default Roshan");
        }

        public void write()
        {
            Console.WriteLine("Roshan is  writing");
        }

    }



    


