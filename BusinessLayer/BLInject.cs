using DataLayer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class BLInject : TestInject
    {
        public BLInject(IConfiguration configuration) : base(configuration)
        {
        }
        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);
            services.AddTransient<ISampleRepo, SampleRepo>();
        }
    }
}
