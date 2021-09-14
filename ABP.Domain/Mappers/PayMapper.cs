using ABP.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.Domain.Mappers
{
    public class PayMapper:ClassMap<PayEntity>
    {
        public PayMapper()
        {
            // 禁用惰性加载
            Not.LazyLoad();
            // 映射到表tweet
            // 主键映射
            Id(x => x.Id).Column("id");
            Table("pay");
            // 字段映射
            Map(x => x.PayAmount).Column("pay_amount");
            Map(x => x.PayTime).Column("pay_time");
            Map(x => x.PayBy).Column("pay_by");
        }
    }
}
