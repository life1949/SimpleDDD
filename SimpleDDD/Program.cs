using SimpleDDD.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome ddd");       
     
        }

        class WriteCommand : Command
        {
            public int i;

            public WriteCommand(int j)
            {
                i = j;
            }
        }

        class CommandHandler : ICommandHandler<WriteCommand>
        {
            public void Execute(WriteCommand command)
            {
                Console.WriteLine("这里是 ddd " + command.i);
            }
        }

    }
}
