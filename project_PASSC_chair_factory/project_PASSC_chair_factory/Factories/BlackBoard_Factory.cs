using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_PASSC_chair_factory
{
    class BlackBoard_Factory :Factory
    {
        List<Chair> chairs = new List<Chair>();
        List<Worker> workers = new List<Worker>();

        public BlackBoard_Factory( List<Chair> _chairs, List<Worker> _workers)
        {
            chairs = _chairs;
            workers = _workers;
        }
        public void buildChair(Chair chair)
        {
            int cnt = 0;

            foreach(var item in chairs)
            {
                String itemType = getItemType(item.GetType().ToString());
                Console.WriteLine("----Start building type of chair " + itemType
                    + " with number " + cnt + "----\n");
                if (!item.checkState())
                {
                    foreach(var worker in workers)
                    {
                        worker.operate(item);
                    }
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
            return type.Substring(type.LastIndexOf('.')+1);
        }
    }
}
