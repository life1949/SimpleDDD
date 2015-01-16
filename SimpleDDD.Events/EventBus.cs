using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDDD.Events
{
    public class EventBus : IEventBus
    {
        //这里需要有好的记录注册方式，目前用内存的方式
        //private IEventHandlerFactory _handlerFactory;
        private Dictionary<Type, List<dynamic>> _handlerFactory;

        public EventBus()
        {
            _handlerFactory = new Dictionary<Type, List<dynamic>>();
        }

        public void Publish<T>(T ievent) where T : IEvent
        {
            dynamic handler;
            var value = _handlerFactory[ievent.GetType()];
            foreach (var item in value)
            {
                item.Handle(ievent);
            }
        }

        public void Register(Type type, dynamic handler)
        {
            if (!_handlerFactory.ContainsKey(type))
            {
                var list = new List<dynamic>();
                list.Add(handler);
                _handlerFactory.Add(type, list);
            }
            else
            {
                var value = _handlerFactory[type];
                value.Add(handler);
            }

            
        }
    }
}
