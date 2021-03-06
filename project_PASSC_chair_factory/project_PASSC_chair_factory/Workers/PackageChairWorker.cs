﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace project_PASSC_chair_factory
{
    class PackageChairWorker : Worker
    {
        public PackageChairWorker(String name, int workTime) : base(name, workTime) { base.eventMessage = "DONE_P"; }

        public override void operate(Chair chair)
        {
            if (!chair.package)
            {
                chair.package = true;
                Console.WriteLine(workerName + " done packing chair.");
                System.Threading.Thread.Sleep(workTime * 100);
            }
        }
        public override void operateBus(string Message, Chair chair)
        {
            if (Message.Equals("NEED_P"))
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
