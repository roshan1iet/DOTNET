namespace OOPAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


        public class PDF 
        {
            protected override void Parse()
            {
                
                Console.WriteLine("PDF Parsed.");
            }
            protected override void Validate()
            {
              
                Console.WriteLine("PDF Validated.");
            }
            protected override void Save()
            {
                
                Console.WriteLine("PDF Saved.");
            }
        }
        public class TXT
        {
            protected override void Parse()
            {
                
                Console.WriteLine("PDF Parsed.");
            }
            protected override void Validate()
            {
               
                Console.WriteLine("PDF Validated.");
            }
            protected override void Save()
            {
               
                Console.WriteLine("PDF Saved.");
            }
        }
        public class Docs : 
        {
            protected override void Parse()
            {
              
                Console.WriteLine("PDF Parsed.");
            }
            protected override void Validate()
            {
           
                Console.WriteLine("PDF Validated.");
            }
            protected override void Save()
            {
               
                Console.WriteLine("PDF Saved.");
            }
        }
        public class XML
        {
            protected override void Parse()
            {
                
                Console.WriteLine("PDF Parsed.");
            }
            protected override void Validate()
            {
               //500lines code here
                Console.WriteLine("PDF Validated.");
            }
            protected override void Save()
            {
                //500lines code here
                Console.WriteLine("PDF Saved.");
            }
        }
    }
}
