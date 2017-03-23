using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_PASSC_chair_factory
{
    class BusEventFactory:Factory
    {
        List<Chair> chairs = new List<Chair>();
        List<Worker> workers = new List<Worker>();
        private PublishEvent pub = new PublishEvent();
        private PublishEventWorker pubWorker = new PublishEventWorker();
        private List<Subscriber> subscribers = new List<Subscriber>();
        private List<WorkersSubscribe> subscribersWorkers = new List<WorkersSubscribe>();

        public BusEventFactory(List<Chair> _chairs,List<Worker> _workers)
        {
            chairs = _chairs;
            workers = _workers;
            foreach( var worker in workers)
            {
                subscribers.Add(new Subscriber(worker, pub));
                subscribersWorkers.Add(new WorkersSubscribe(worker, pubWorker));
            }

        }
        public  void buildChair(Chair chair)
        {
            int cnt = 0;

            foreach (var itemChair in chairs)
            {
                String itemType = getItemType(itemChair.GetType().ToString());
                Console.WriteLine("----Start building type of chair " + itemType
                    + " with number " + cnt + "----\n");
                if (!itemChair.checkState())
                {
                    //pub.publishChair(itemChair);
                    foreach (var worker in workers)
                        pubWorker.publishWorker(worker, itemChair);
                }
                else
                {
                    Console.WriteLine("----Done building type of chair " + itemType
                    + " with number " + cnt + "----\n");
                }

                cnt++;
            }
        }
        private String getItemType(String type)
        {
            return type.Substring(type.LastIndexOf('.') + 1);
        }
    }
}
