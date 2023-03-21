using System.Net.WebSockets;
using System.Threading.Channels;

namespace CSharp
{
    class parent
    {
        protected int a;
        protected parent(int a)
        {
            this.a = a;
            Console.WriteLine(a);
        }
    }
    class children : parent
    {
        protected children(int a) : base(15)
        {
            this.a = a;
            Console.WriteLine(a);
        }
    }
    class last : children
    {
        public last() : base(10)
        {

        }
    }
    class Program
    {
        static void Main()
        {
            parent sim = new last();
        }

    }
}