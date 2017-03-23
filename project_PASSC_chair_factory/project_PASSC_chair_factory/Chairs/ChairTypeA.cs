using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_PASSC_chair_factory
{
    class ChairTypeA : Chair
    {
        public ChairTypeA() : base() { }

        public override Boolean checkState()
        {
            if (seat && feet && stabilizerBar && backRest && package)
                return true;
            else
                return false;
        }
    }
}
