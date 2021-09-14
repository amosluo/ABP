using Abp.Application.Services;
using ABP.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.Application.Interfaces
{
    public interface IPayAppService : IApplicationService
    {
        object GetObjects(string keyword);
        object CreateObject(CreatePayDto input);
    }
}
