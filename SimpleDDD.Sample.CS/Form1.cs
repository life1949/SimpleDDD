using SimpleDDD.Commands;
using SimpleDDD.Events;
using SimpleDDD.Sample.CS.Core.CSCommand;
using SimpleDDD.Sample.CS.Core.CSCommandHandler;
using SimpleDDD.Sample.CS.Core.CSDomain;
using SimpleDDD.Sample.CS.Core.CSEvent;
using SimpleDDD.Sample.CS.Core.CSEventHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDDD.Sample.CS
{
    public partial class Form1 : Form
    {
        CommandBus _commandBus;
        EventBus _eventBus;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _commandBus = new CommandBus();
            _eventBus = new EventBus();
            
            _commandBus.Register(typeof(SubmitWeekReportCommand), new SubmitWeekReportCommandHandler());


            _eventBus.Register(typeof(WeekReportCreateEvent), new HongGeEventHandler(this));
            //_eventBus.Register(typeof(WeekReportCreateEvent), new LaoDaEventHandler(this));
        }

        public void HongGe(string value)
        {
            textBox3.Text = value;
        }

        public void Laoda(string value)
        {
            textBox4.Text = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WeekReport.Set(_eventBus);

            var command = new SubmitWeekReportCommand(Guid.NewGuid(), -1, textBox1.Text, textBox2.Text);
            _commandBus.Send(command);            
        }
    }
}
