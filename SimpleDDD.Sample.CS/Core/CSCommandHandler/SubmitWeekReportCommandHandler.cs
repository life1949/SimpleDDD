using SimpleDDD.Commands;
using SimpleDDD.Sample.CS.Core.CSCommand;
using SimpleDDD.Sample.CS.Core.CSDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDDD.Sample.CS.Core.CSCommandHandler
{
    public class SubmitWeekReportCommandHandler : ICommandHandler<SubmitWeekReportCommand>
    {        
        public void Execute(SubmitWeekReportCommand command)
        {
            WeekReport.Create(command.Title, command.Content);
        }
    }
}
