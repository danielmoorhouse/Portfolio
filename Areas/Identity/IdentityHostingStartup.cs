using System;
using danielmoorhouse.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(danielmoorhouse.Areas.Identity.IdentityHostingStartup))]
namespace danielmoorhouse.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<danielmoorhouseIdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("danielmoorhouseIdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<danielmoorhouseIdentityDbContext>();
            });
        }
    }
}