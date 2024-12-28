namespace _15GenericCollection
{
    
    public delegate R MyDelegate<T1, R>(T1 para1);
    public delegate R MyDelegate<T1, T2, R>(T1 para1, T2 para2);
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Demo<P, Q, R, T>
    {
        public R Display(P p1, Q p2, R p3, T p4)
        {
            return p3;
        }
    }
    public class Test<T1, T2, T3, T4>
    {
        public T3 Display(T1 p1, T2 p2, T3 p3, T4 p4)
        {
            return p3;
        }
    }
    public class CMath<T> 
    {
        public void Swap(ref T x, ref T y) 
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
       
        public void Calculate(T x, T y, out T sum, out T product)
        {
            
            dynamic para1 = x;
            dynamic para2 = y;

            sum = para1 + para2;
            product = para1 * para2;
        }
    }
}
