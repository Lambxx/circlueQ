using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circlueQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Q testq = new Q(3);
           Console.WriteLine( testq.qEnqueue(0));
            Console.WriteLine(testq.qEnqueue(1));
            Console.WriteLine(testq.qEnqueue(2));
            Console.WriteLine(testq.qEnqueue(3));
            Console.WriteLine(testq.dQueue());
            Console.WriteLine(testq.dQueue());
            Console.WriteLine(testq.peek());
            Console.ReadLine();
        }
    }

    class Q {
        private int head;
        private int tail;
        private int []qArr;
      

        public Q(int size){
            size++; // We need to account for the empty space which is left as per text book 
            this.qArr = new int[size];
            this.head = 0;
            this.tail = 0;
            Console.WriteLine("new Q of size " +( qArr.Length - 1 ) + " created");
            Console.ReadLine();


        }
        public bool qEnqueue(int val) {
            if (((head + 1) % (qArr.Length)) == tail)
            {
                return false;
            }
            else {
                qArr[head] = val;
                head = (head + 1) % qArr.Length;
                return true;
            }
        }
        public int dQueue()
        {
            if (head == tail)
            {
                throw new InvalidOperationException("Empty Q cannot be dQ'd");
            }
            else {
                int val = qArr[tail];
                tail = (tail + 1) % (qArr.Length);
                return val;

            }
        }

        public int peek()
        {
            if (head == tail)
            {
                throw new InvalidOperationException("Empty Q cannot be peeked");
            }
            else
            {
                int val = qArr[tail];
                return val;

            }
        }
    }
}
