using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_PASSC_chair_factory
{
    class ChairTypeD:Chair
    {
        public ChairTypeD() : base() { base.stabilizerBar = true; }
        public override Boolean checkState()
        {
            if (seat && feet && backRest && package)
                return true;
            else
                return false;
        }
    }
}
