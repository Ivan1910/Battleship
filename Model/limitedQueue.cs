using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class limitedQueue<T> : Queue<T>
    {
        public limitedQueue(int len)
        {
            Len = len;
        }
        public new void Enqueue(T item)
        {
            base.Enqueue(item);
            while (Count > Len)
            {
                Dequeue();
            }
        }
        private readonly int Len;
    }

}