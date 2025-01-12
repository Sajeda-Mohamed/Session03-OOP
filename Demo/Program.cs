using Common;
using TypeBbb = Common.TypeB;
using TypeB = Demo.New.TypeB;
namespace Demo
{
    internal class Program
    {
        #region Polymorphism[Overloading]
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Sum(int x, double y)
        {
            return x + y;
        } 
        #endregion

        static void Main(string[] args)
        {
            #region Polymorphism [Overriding]
            TypeA typeA = new TypeA(1);
            typeA.Fun1();

            TypeB typeB = new TypeB(1,2);
            #endregion
        }
    }
}
