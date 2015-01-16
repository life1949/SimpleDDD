using SimpleDDD.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDDD.Sample.CS.Core.CSCommand
{
    public class SubmitWeekReportCommand : Command
    {
        public string Title { get; private set; }
        public string Content { get; private set; }

        public string message;

        public SubmitWeekReportCommand(Guid id, int version, string title, string content)
            : base(id, version)
        {
            Title = title;
            Content = content;
        }
    }
}
