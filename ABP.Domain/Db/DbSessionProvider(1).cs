using Abp.Dependency;
using Abp.NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using MySql.Data.MySqlClient;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ABP.Domain.Db
{
    public class DbSessionProvider : ISessionProvider, ISingletonDependency, IDisposable
    {
        protected FluentConfiguration FluentConfiguration { get; private set; }

        private ISessionFactory _sessionFactory;

        private ISession _session;
        public ISession Session
        {
            get
            {
                if (_session != null)
                {
                    // 每次访问都flush上一个session。这里有效率和多线程问题，暂且这样用，后面会改。
                    _session.Flush();
                    _session.Dispose();
                }
                _session = _sessionFactory.OpenSession();
                return _session;
            }
        }

        public DbSessionProvider()
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
            _sessionFactory = FluentConfiguration.BuildSessionFactory();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
