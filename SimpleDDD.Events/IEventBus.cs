using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDDD.Events
{
    public interface IEventBus
    {
        void Publish<T>(T ievent) where T : IEvent;
    }
}
