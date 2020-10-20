using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
        class CPUQueue
        {
            private Queue<CPUProcess> queue;
            public int maxSize;
            public int id;
            private static readonly object syncLock = new object();
            public CPUQueue(int id)
            {
                queue = new Queue<CPUProcess>();
                maxSize = 0;
                this.id = id;
            }
        public void InsertProcess(CPUProcess process)
        {
            lock (syncLock)
            {
                if (queue == null || process == null)
                {
                    throw new Exception("Null");
                }
                queue.Enqueue(process);
                maxSize++;
            }
        }
            public CPUProcess Dequeue()
            {
            lock (syncLock)
            {
                return queue.Dequeue();
            }
            }

            public bool isEmpty()
            {
                return (queue.Count == 0);
            }
            public string toString()
            {
                return queue.ToString();
            }
            public void showAllProcesses()
        {
            Console.WriteLine("Common q");
            for(int i = 0; i < queue.Count; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
        }
    }

