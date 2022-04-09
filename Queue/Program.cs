using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Кафедра");
            queue.Enqueue("комп'ютерних");
            queue.Enqueue("інформаційних");
            queue.Enqueue("технологій");

            while (!queue.IsEmpty)
            { Console.Write(queue.Dequeue() + " "); }

            Console.ReadKey();
        }
    }
}

