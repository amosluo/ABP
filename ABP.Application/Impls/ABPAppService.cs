using Abp.Application.Services;
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
    public class ABPAppService : ApplicationService, IABPAppService
    {
        /// <summary>
        /// 属性注入
        /// </summary>
        public IPayRepository PayRepository { get; set; }
        public object CreateObject(CreatePayDto input)
        {
            var tweet = new PayEntity
            {
                PayAmount = input.PayAmount,
                PayTime = DateTime.Now,
                PayBy = "test"
            };
            var o = PayRepository.Insert(tweet);
            return o;
        }

        public IPayQueryRepository PayQueryRepository { get; set; }
        public object GetObjects(string keyword)
        {
            return PayQueryRepository.SearchPay(keyword);
        }
    }
}
