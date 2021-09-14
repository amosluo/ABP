using ABP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.Domain.Repositories
{
    public interface IPayQueryRepository
    {
        IList<PayEntity> SearchPay(string keyword);
    }
}
