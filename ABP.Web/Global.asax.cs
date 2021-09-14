using Abp.Castle.Logging.Log4Net;
using Abp.Dependency;
using Abp.Web;
using Castle.Facilities.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ABP_Web
{
    public class Global : AbpWebApplication<ABPWebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //使用log4net日志功能,要在调用base.Application_Start(sender,e)方法前
            IocManager.Instance.IocContainer.AddFacility<LoggingFacility>(
                f =>
                {
                    //指定日志文件路径
                    f.UseAbpLog4Net().WithConfig(Server.MapPath("log4net.config"));
                }
            );

            base.Application_Start(sender, e);
        }
    }
}