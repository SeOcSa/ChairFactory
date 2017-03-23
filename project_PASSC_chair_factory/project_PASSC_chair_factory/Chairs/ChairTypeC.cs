using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_PASSC_chair_factory
{
    class ChairTypeC : Chair
    {
        public ChairTypeC() : base() { base.backRest = true; base.stabilizerBar = true; }

        public override Boolean checkState()
        {
            if (seat && feet && package)
                return true;
            else
                return false;
        }

    }
}
