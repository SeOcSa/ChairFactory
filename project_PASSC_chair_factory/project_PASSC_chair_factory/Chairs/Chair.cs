using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_PASSC_chair_factory
{
     abstract class Chair
    {
        public Boolean seat
        {
            get; set;
        }
        public Boolean feet
        {
            get; set;
        }
        public Boolean stabilizerBar
        {
            get; set;
        }
        public Boolean backRest
        {
            get; set;
        }
        public Boolean package
        {
            get; set;
        }

        public abstract Boolean checkState();
    }
}
