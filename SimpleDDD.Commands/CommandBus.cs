using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDDD.Commands
{
    public class CommandBus : ICommandBus
    {
        //这里需要有好的记录注册方式，目前用内存的方式
        //private ICommandHandlerFactory _handlerFactory;
        private Dictionary<Type, dynamic> _handlerFactory;

        public CommandBus()
        {
            _handlerFactory = new Dictionary<Type, dynamic>();
        }

        public void  Send<T>(T command) where T : Command
        {
            dynamic handler;
            if (_handlerFactory.TryGetValue(command.GetType(), out handler))
            {
                handler.Execute(command);
            }
            else
                throw new Exception("未注册对该事件的处理方法");
        }

        public void Register(Type type, dynamic handler)
        {
            _handlerFactory.Add(type, handler);
        }
    }
}
