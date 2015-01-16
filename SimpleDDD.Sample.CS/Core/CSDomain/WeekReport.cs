using SimpleDDD.Events;
using SimpleDDD.Sample.CS.Core.CSEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDDD.Sample.CS.Core.CSDomain
{
    public class WeekReport
    {
        static EventBus _bus;

        public static void Set(EventBus bus)
        {
            _bus = bus;
        }

        public static void Create(string title, string content)
        {
            _bus.Publish(new WeekReportCreateEvent(title, content));
        }
    }
}
