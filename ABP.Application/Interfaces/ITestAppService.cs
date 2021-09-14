using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.Application.Interfaces
{
    public interface ITestAppService : IApplicationService
    {
        void Enqueue(int number);
    }
}
