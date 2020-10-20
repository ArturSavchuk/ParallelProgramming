using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab2
{

    class CPU
    {
        private static int counter = 0;
        int min;
        int max;

        private int time;                             // duration of service of  process
        private bool busy;
        public static int interrupted_count;
        public CPUProcess process; 
        Stopwatch sw = new Stopwatch();
        private static readonly object syncLock = new object();

        public CPU(int min, int max)
        {
            this.min = min;
            this.max = max;
            busy = false;
        }
        public  void setTask(CPUProcess p)
        {  
            // поставить процесс на обработку
            Random random = new Random();
            time = random.Next(min, max);
            Console.WriteLine("Time: " + time + " for operating process " + p.id);
            setProcess(p);
            
        }

        public void setProcess(CPUProcess process)
        {
            this.process = process;
        }
        public bool isBusy()
        {
            return busy;
        }
        public void InterruptProcess()
        {
                interrupted_count++;
                sw.Stop();
                Console.WriteLine(sw.ElapsedMilliseconds + " Remaining to finish process" + process.id);
                sw.Reset();
                setProcess(null);
                busy = false;
        }
        public CPUProcess getProcess()
        {
                return process;   
        }

        public void Run()
        {

            Console.WriteLine("******* CPU started ********");
           
            while (true)
            {
                if (busy == false & process != null)
                {
                    // request for processing
                    busy = true;
                    Console.WriteLine("CPU started processing of: " + process.id);
                    //if(process)
                    sw.Start();
                    Thread.Sleep(time); // simulates processing
                    Console.WriteLine("CPU finished processing of: " + process.id);
                    // remove process
                    setProcess(null);
                    busy = false;
                }
            }
        }
        }
    }