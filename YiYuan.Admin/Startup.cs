﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(YiYuan.Admin.Startup))]

namespace YiYuan.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
