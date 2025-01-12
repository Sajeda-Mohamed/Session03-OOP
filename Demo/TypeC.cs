using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class TypeC : TypeA
    {
        public TypeC()
        {
           TypeA type = new TypeA();
            //typeA.X = 1;=> invalid
            //typeA.Y = 1;=> invalid
            //typeA.Z = 1;=  invalid;

            //X = 10;=> invalid
            //Y = 2;=> valid , private 
            //Z = 3;=> valid , private
        }
    }
}
