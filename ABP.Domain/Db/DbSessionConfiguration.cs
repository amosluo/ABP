using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ABP.Domain.Db
{
    public class DbSessionConfiguration : IDbSessionConfiguration, IDisposable
    {
        protected FluentConfiguration FluentConfiguration { get; private set; }

        public ISessionFactory SessionFactory { get; }

        public DbSessionConfiguration()
        {
            FluentConfiguration = Fluently.Configure();
            FluentConfiguration
                // 配置连接串
                .Database(MySQLConfiguration.Standard.ConnectionString(db =>
                    db.Server("localhost")
                        .Database("pay")
                        .Username("root")
                        .Password("root")
                ))
                // 配置ORM
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .BuildConfiguration();
            // 生成session factory
            SessionFactory = FluentConfiguration.BuildSessionFactory();
        }

        public void Dispose()
        {
            SessionFactory.Dispose();
        }
    }
}
