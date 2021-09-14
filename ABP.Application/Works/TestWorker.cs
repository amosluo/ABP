using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.Threading.BackgroundWorkers;
using Abp.Threading.Timers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.Application.Works
{
    public class TestWorker : PeriodicBackgroundWorkerBase, ISingletonDependency
    {

        public TestWorker(AbpTimer timer)
            : base(timer)
        {
            Timer.Period = 5000; //5 seconds (good for tests, but normally will be more)
        }

        [UnitOfWork]
        protected override void DoWork()
        {
            log4net.LogManager.GetLogger("DebuggerLog").Debug("DoWork DoWork DoWork ...");
        }
    }
}
