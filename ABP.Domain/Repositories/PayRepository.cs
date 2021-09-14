using Abp.Dependency;
using Abp.NHibernate.Repositories;
using ABP.Domain.Db;
using ABP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.Domain.Repositories
{
    public class PayRepository : NhRepositoryBase<PayEntity, int>, IPayRepository
    {
        public PayRepository()
        : base(IocManager.Instance.Resolve<DbSessionProvider>())
        { 
        
        }
    }
}
