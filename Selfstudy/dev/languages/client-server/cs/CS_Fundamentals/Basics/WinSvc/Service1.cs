using System.Diagnostics;
using System.ServiceProcess;

namespace WinSvc
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            EventLog.WriteEntry("OnStart");
        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("OnStop");
        }
    }
}
