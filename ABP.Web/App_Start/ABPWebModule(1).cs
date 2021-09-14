using Abp.Application.Services;
using Abp.Castle.Logging.Log4Net;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Web.Mvc;
using Abp.WebApi;
using ABP.Application;
using Castle.Facilities.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Hosting;

namespace ABP_Web
{
    [DependsOn(typeof(AbpWebApiModule), typeof(AbpWebMvcModule), typeof(ABPApplicationModule))]
    public class ABPWebModule : AbpModule
    {

        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;   //未登录的用户是否记录日志，默认false
        }

        public override void Initialize()
        {

            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            //动态API
            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                //注入Application层的public方法生成相应的API接口
                .ForAll<IApplicationService>(typeof(ABPApplicationModule).Assembly, "ABP")
                //根据方法名称绑定相应的Http Method动词
                .WithConventionalVerbs()
                //构造控制器
                .Build();
        }

        public override void PostInitialize()
        {
            base.PostInitialize();

        }
    }
}