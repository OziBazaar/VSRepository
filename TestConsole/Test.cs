using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Test
    {
        public int Id { get; set; }
        public Test()
        {
            int a = 1;
            a = a + 1;
        }
        public Test(int a)
        {
            Id=a;
        }
    }
    public class Circle
    {
        public int Radious { get; set; }
        public int Xc { get; set; }
        public int Yc { get; set; }

    }
}
