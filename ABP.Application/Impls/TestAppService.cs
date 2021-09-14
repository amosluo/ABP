using Abp.Application.Services;
using Abp.BackgroundJobs;
using ABP.Application.Interfaces;
using ABP.Application.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.Application.Impls
{
    public class TestAppService : ApplicationService, ITestAppService
    {
        //属性注入：后台任务管理器
        public IBackgroundJobManager jobManager { get; set; }

        public void Enqueue(int number)
        {
            jobManager.Enqueue<TestJob, int>(number);
        }

    }
}
