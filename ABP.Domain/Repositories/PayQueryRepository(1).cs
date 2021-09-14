using Abp.Dependency;
using ABP.Domain.Db;
using ABP.Domain.Entities;
using ABP.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.Domain.Repositories
{
    public class PayQueryRepository : BaseQueryService, IPayQueryRepository
    {
        public PayQueryRepository() : base(IocManager.Instance.Resolve<UnitOfWorkDbSessionProvider>())
        { }

        public IList<PayEntity> SearchPay(string keyword)
        {
            var sql = @"select
                        id Id,
                        pay_amount payAmount,
                        pay_time PayTime,
                        pay_by PayBy
                    from pay
                    where pay_by LIKE CONCAT('%',@Keyword,'%')";
            return Query<PayEntity>(sql, new { Keyword = keyword ?? "" }).ToList();
        }
    }
}
