using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Demo.New
{
    public class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }
        //Applying override by KeyWord "New"
        public new void Fun1()
        {
            Console.WriteLine("I'm Drived [Child]");
        }
        //Applying override by KeyWord "Override"
        public override void Fun2()
        {
            Console.WriteLine($"B is {B}");
        }
    }
}
