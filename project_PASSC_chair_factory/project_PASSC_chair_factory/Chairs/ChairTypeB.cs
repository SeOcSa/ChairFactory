using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_PASSC_chair_factory
{
    class ChairTypeB : Chair
    {
        public ChairTypeB() : base() { base.backRest = true; }

        public override Boolean checkState()
        {
            if (seat && feet && stabilizerBar && package)
                return true;
            else
                return false;
        }
    }
}
