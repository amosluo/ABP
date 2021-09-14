using Abp.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ABP.Infrastructure
{
    public class ABPInfrastructureModule:AbpModule
    {
        public override void Initialize()
        {
            //向IOC容器内注册满足常规注册条件（Repositories， Domain Services， Application Services， MVC 控制器和Web API控制器）与实现帮助接口（ITransientDependency和ISingletonDependency）的类
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
