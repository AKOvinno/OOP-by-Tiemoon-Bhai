using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> someValues = new Queue<int>();
            someValues.Enqueue(100);
            someValues.Enqueue(200);
            someValues.Enqueue(300);

            Console.WriteLine(someValues.Dequeue());
            Console.WriteLine(someValues.Dequeue());
            Console.WriteLine(someValues.Dequeue());
            Console.ReadKey();
        }
    }
}
