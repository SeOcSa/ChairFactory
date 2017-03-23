using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace project_PASSC_chair_factory
{
    class SeatWorker : Worker
    {
        public SeatWorker(String name, int workTime) : base(name, workTime){ base.eventMessage = "DONE_C"; }
        public override void operate(Chair chair)
        {
            if (!chair.seat)
            {
                chair.seat = true;
                Console.WriteLine(workerName + " done cuting seat.");
                System.Threading.Thread.Sleep(workTime * 100);
                
            }
        }
        public override void operateBus(string Message, Chair chair)
        {
            if (Message.Equals("NEED_C"))
            {
                this.operate(chair);
            }
            else
            {
                Console.WriteLine(this.workerName + " said that " + Message + " is not his job");
            }
        }
    }
}
