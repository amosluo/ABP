using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.Domain.Entities
{
    public class PayEntity : Entity<int>
    {
        public decimal PayAmount { get; set; }
        public DateTime PayTime { get; set; }
        public string PayBy { get; set; }
    }
}
