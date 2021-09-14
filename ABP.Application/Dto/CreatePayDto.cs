using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.Application.Dto
{
    public class CreatePayDto
    {
        public decimal PayAmount { get; set; }
        public DateTime PayTime { get; set; }
        public string PayBy { get; set; }
    }
}
