﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiYuan.Entity
{
    /// <summary>
    /// 管理角色表
    /// </summary>
    public class AdminRule : EntityBase<int>
    {
        /// <summary>
        /// 角色
        /// </summary>
        public string Name { get; set; }
    }
}
