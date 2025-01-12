namespace Common
{
    public class TypeA
    {
        protected internal int Z;
        protected int Y;
        private protected int X;
        public int A{ get; set; }
        public TypeA(int _A)
        {
            A = -A;
        }
        public void Fun1()
        {
            Console.WriteLine("I'm base [Parent]");
        }
        public virtual void Fun2()
        {
            Console.WriteLine($"A = {A}");
        }
    }
}
