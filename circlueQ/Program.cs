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
            Q testq = new Q(10);
            testq.qEnqueue(0);
        }
    }

    class Q {
        private int head;
        private int tail;
        private int []qArr;
      

        public Q(int size){
            this.qArr = new int[size];
            this.head = 0;
            this.tail = 0;
            Console.WriteLine("new Q of size " + qArr.Length + " created");
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
    }
}
