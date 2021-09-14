using Abp.Domain.Repositories;
using ABP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.Domain.Repositories
{
    public interface IPayRepository : IRepository<PayEntity, int>
    {
    }
}
