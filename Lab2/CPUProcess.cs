using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class CPUProcess
    {
        public int time_slot;
        public int id = counter++;
        public static int counter = 1;
        public int flow;
        private int min, max;
        public CPUProcess(int time_slot, int flow)
        {
            this.time_slot = time_slot;
            this.flow = flow;
            
        }
        public void SetID()
        {
            id = counter;
        }
        
        override
        public string ToString()
        {
            return string.Format("Process {0}; flow:   {1}, time to next process generation:   {2}", id, flow, time_slot);    
        }
    }
}
