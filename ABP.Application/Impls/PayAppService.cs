using Abp.Application.Services;
using Abp.Auditing;
using ABP.Application.Dto;
using ABP.Application.Interfaces;
using ABP.Domain.Entities;
using ABP.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.Application.Impls
{
    [Audited]
    public class PayAppService : ApplicationService, IPayAppService
    {
        /// <summary>
        /// 属性注入
        /// </summary>
        public IPayRepository PayRepository { get; set; }

        /// <summary>
        /// 属性注入
        /// </summary>
        public IPayRepository PayRepository2 { get; set; }
        public object CreateObject(CreatePayDto input)
        {
            var tweet = new PayEntity
            {
                PayAmount = input.PayAmount,
                PayTime = DateTime.Now,
                PayBy = "test"
            };
            var o = PayRepository.Insert(tweet);
            PayRepository2.Insert(new PayEntity
            {
                PayAmount = input.PayAmount,
                PayTime = DateTime.Now,
                PayBy = "test22"
            });
            return o;
        }

        public IPayQueryRepository PayQueryRepository { get; set; }
        public object GetObjects(string keyword)
        {
            log4net.LogManager.GetLogger("DebuggerLog").Debug("hello debugger");
            log4net.LogManager.GetLogger("AccessLog").Info("hello AccessLog");
            return PayQueryRepository.SearchPay(keyword);
        }
    }
}
