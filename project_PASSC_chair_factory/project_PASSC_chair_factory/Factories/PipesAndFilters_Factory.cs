using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_PASSC_chair_factory
{
    class PipesAndFilters_Factory : Factory
    {
        private List<Worker> workers
        {
            get; set;
        }

        public PipesAndFilters_Factory(List<Worker> _workers)
        {
            workers = _workers;
        }

        public void buildChair(Chair chair)
        {
            foreach(var worker in workers)
            {
                worker.operate(chair);
            }
            
        }
    }
}
