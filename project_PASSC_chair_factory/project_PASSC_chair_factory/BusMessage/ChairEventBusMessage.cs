using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_PASSC_chair_factory
{
    class ChairEventBusMessage :EventArgs
    {
        public ChairEventBusMessage(String s, Chair _chair)
        {
            message = s;
            chiar = _chair;
        }
        private String message;
        private Chair chiar;

        public Chair Chair
        {
            get { return chiar; }
            set { chiar = value; }
        }
        public String Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
