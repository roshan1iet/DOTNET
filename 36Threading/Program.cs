using System.Diagnostics;

namespace _36Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //for (int i = 0; i < 10; i++)
            //{
            //    DoSomeThingComplex();
            //}
            //watch.Stop();
            //Console.WriteLine("Time Taken = {0}", watch.ElapsedTicks);

            #endregion
            #region Thread
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //for (int i = 0; i < 10; i++)
            //{
            //    Thread t1 = new Thread(new ThreadStart(DoSomeThingComplex));
            //    t1.Start();
            //    Console.WriteLine("Current Thread ID:{0}",Thread.CurrentThread.ManagedThreadId);
            //}
            //watch.Stop();
            //Console.WriteLine("Time taken = {0}", watch.ElapsedTicks);
            #endregion

            #region Explicit Parallel Programming - Multiple Tasks
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //for (int i = 0; i < 10; i++)

            //{
            //    Task t1 = new Task(new Action(DoSomeThingComplex));

            //    t1.Start();
            //    Console.WriteLine("Current Task ID:{0}", t1.Id.ToString());
            //}
            //watch.Stop();
            //Console.WriteLine("Time taken = {0}", watch.ElapsedTicks); 
            #endregion

            #region Parallel.Foreach - Implicit Parallel Prog.
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //Parallel.ForEach(arr, (i) =>
            //{
            //    Console.WriteLine($"Number : {i}, Task Id: {Task.CurrentId}, Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            //    Thread.Sleep(1000);
            //});
            //watch.Stop();
            //Console.WriteLine("Time taken = {0}", watch.ElapsedTicks);  
            #endregion

            #region MaxDegreeOfParallelism 
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var options = new ParallelOptions { MaxDegreeOfParallelism = 3 };
            //Parallel.ForEach(arr, options, (i) =>
            // {
            //     Console.WriteLine($"Number : {i}, Task Id: {Task.CurrentId}, Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            // }); 
            #endregion

            #region Exception Handling Using Parrllel Foreach

            //    try
            //    {
            //        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            //        Parallel.ForEach(numbers, (x) =>
            //        {
            //            Console.WriteLine($"Number: {x}, Task Id: {Task.CurrentId}, Thread Id: {Thread.CurrentThread.ManagedThreadId}");

            //            if (x == 4)
            //                throw new Exception("simulated Exception");
            //        });
            //    }
            //    catch (AggregateException ex)
            //    {
            //        foreach (var innerExp in ex.InnerExceptions)
            //        {
            //            {
            //                Console.WriteLine($"Exception : {innerExp.Message} ");
            //            }

            //        }
            //    }
            //    Console.WriteLine("Parallel Foreach with exception Handling is complete");

            #endregion



            //List<Emp> allEmployees = new List<Emp>()
            //{
            //    new Emp(){Id=1, Name="Roshan", Address="Gadchiroli"},
            //    new Emp(){Id=2, Name="Rohit", Address="Nanded" },
            //    new Emp(){Id=3, Name="Rakesh", Address="pune"},
            //    new Emp(){Id=4, Name="Ramesh", Address="Mumbai" },
            //    new Emp(){Id=3, Name="Ranga", Address="pune"},
            //    new Emp(){Id=4, Name="Rangoli", Address="Mumbai" }

            //};
            //Stopwatch watch = new Stopwatch();
            //watch.Start();

            //var result=( from emp in allEmployees.AsParallel()
            //             where emp.Address.StartsWith("M")
            //             select emp ).ToList();
            //watch.Stop();
            //Console.WriteLine("Time taken = {0}", watch.ElapsedTicks);

            //foreach (var emp in result)
            //{
            //    Console.WriteLine($"Id : {emp.Id}, Name: {emp.Name}, Address: {emp.Address}");
            //}

            

        }

        public static void DoSomeThingComplex()
        {
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {

                }
            }
        }



    }
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
