﻿using SimpleDDD.Events;
using SimpleDDD.Sample.CS.Core.CSEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDDD.Sample.CS.Core.CSEventHandler
{
    public class LaoDaEventHandler : IEventHandler<WeekReportCreateEvent>
    {
        Form1 _form;

        public LaoDaEventHandler(Form1 form)
        {
            _form = form;
        }

        public void Handle(WeekReportCreateEvent handle)
        {
            _form.Laoda(string.Format("问题是：{0}，内容是：{1}。请老大处理", handle.Title, handle.Content));
        }
    }
}
