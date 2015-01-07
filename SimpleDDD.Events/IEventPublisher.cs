using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDDD.Events
{
    public interface IEventPublisher
    {
        void Publisher<T>(T ievent) where T : IEvent;
    }
}
