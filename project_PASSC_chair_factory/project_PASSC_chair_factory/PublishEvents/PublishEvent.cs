using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_PASSC_chair_factory
{
    class PublishEvent
    {
        public event EventHandler<ChairEventBusMessage> RaiseChairEvent;
        public void publishChair(Chair chair)
        {
            if(!chair.seat)
            {
                OnRaiseCustomEvent(new ChairEventBusMessage("NEED_C", chair));
            }

            if (!chair.feet)
            {
                OnRaiseCustomEvent(new ChairEventBusMessage("NEED_F", chair));
            }

            if (!chair.stabilizerBar)
            {
                OnRaiseCustomEvent(new ChairEventBusMessage("NEED_S", chair));
            }

            if (!chair.backRest)
            {
                OnRaiseCustomEvent(new ChairEventBusMessage("NEED_B", chair));
            }
            if (!chair.package)
            {
                OnRaiseCustomEvent(new ChairEventBusMessage("NEED_P", chair));
            }
        }
        protected virtual void OnRaiseCustomEvent(ChairEventBusMessage e)
        {
            EventHandler<ChairEventBusMessage> handler = RaiseChairEvent;

            // Event will be null if there are no subscribers
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
