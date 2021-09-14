using Abp.BackgroundJobs;
using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.Application.Jobs
{
    /// <summary>
    /// 测试后台任务
    /// </summary>
    public class TestJob : BackgroundJob<int>, ITransientDependency
    {
        public override void Execute(int args)
        {
            log4net.LogManager.GetLogger("DebuggerLog").Debug(args);
        }
    }
}
