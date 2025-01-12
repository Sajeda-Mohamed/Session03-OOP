using TypeB = Common.TypeB;
using TypeBB0 = Demo.New.TypeB;
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
            
        }
    }
}
