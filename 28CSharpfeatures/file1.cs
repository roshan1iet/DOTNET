using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28CSharpfeatures
{
    public class parent
    {
        public void fruit()
        {
            Console.WriteLine("Mango");
        }

    }
    public partial class CMath:parent
        {
        public int add(int x,int y)
    {
        return  x + y;
    }
        }
}
