﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiYuan.Entity
{
    /// <summary>
    /// 用户积分币
    /// </summary>
    public class UserIntegralCurrency : EntityBase<int>
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public decimal Price { get; set; }
    }
}
