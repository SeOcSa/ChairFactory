using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_PASSC_chair_factory
{
    
    abstract class Worker
    {
        public String workerName
        {
            get; set;
        }
        public int workTime
        {
            get; set;
        }
        public String eventMessage
        {
            protected set;
            get;
        }
        public Worker(String _workerName, int _workTime)
        {
            workerName = _workerName;
            workTime = _workTime;
        }
        //public Worker(String _workerName, int _workTime, PublishEvent _pub, List<Subscriber> _subscribers)
        //{
        //    workerName = _workerName;
        //    workTime = _workTime;
        //    pub = _pub;
        //    subscribers = _subscribers;
        //}
        public abstract void operate(Chair chair);

        public abstract void operateBus(String Message, Chair chair);
    }
}
