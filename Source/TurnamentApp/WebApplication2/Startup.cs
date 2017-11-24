using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using Turnament_NameSpace;
using System.Web;
[assembly: OwinStartup(typeof(WebApplication2.Startup))]

namespace WebApplication2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

    }

}
