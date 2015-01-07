using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDDD.Commands
{
    public class Command : ICommand
    {
        public Guid ID { get; private set; }
    }
}
