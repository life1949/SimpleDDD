using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDDD.Events
{
    public class Event:IEvent
    {
        public Guid ID { get; private set; }
        public Guid AggregateID { get; set; }
        public int Version { get; set; }
    }
}
