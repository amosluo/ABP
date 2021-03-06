using Abp.Dependency;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.Domain.Db
{
    public interface IDbSessionConfiguration : ISingletonDependency
    {
        ISessionFactory SessionFactory { get; }
    }
}
