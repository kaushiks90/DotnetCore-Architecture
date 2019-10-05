using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore_Architecture.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetCore_Architecture.Installer
{
    public class DbInstaller : IInstaller
    {
        public void IInstallServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddDbContext<Data.DbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<Data.DbContext>();


            services.AddSingleton<IPostService, PostService>();
        }
    }
}
