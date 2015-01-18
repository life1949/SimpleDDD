using SimpleDDD.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDDD.Sample.CS.Core.CSEvent
{
    public class WeekReportCreateEvent : Event
    {
        public string Title { get; private set; }
        public string Content { get; private set; }

        public WeekReportCreateEvent(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
