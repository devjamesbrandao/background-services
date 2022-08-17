using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TimedHostedServiceExample.Model;
using TimedHostedServiceExample.Model.Entities;

namespace TimedHostedServiceExample
{
    public static class DbMigrationHelpers
    {
        public static async Task EnsureSeedData(IApplicationBuilder serviceScope)
        {
            var services = serviceScope.ApplicationServices.CreateScope().ServiceProvider;

            await EnsureSeedData(services);
        }

        public static async Task EnsureSeedData(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope();

            var env = scope.ServiceProvider.GetRequiredService<IWebHostEnvironment>();

            var context = scope.ServiceProvider.GetRequiredService<JobDbContext>();

            await context.Database.EnsureDeletedAsync();

            await context.Database.EnsureCreatedAsync();

            await EnsureSeedUsers(context);
        }

        private static async Task EnsureSeedUsers(JobDbContext context)
        {
            if(await context.JobDatas.AnyAsync()) return;

            await context.JobDatas.AddAsync(new JobData(){ Id = Guid.NewGuid(), Delay = 20 });

            await context.JobDatas.AddAsync(new JobData() { Id = Guid.NewGuid(), Delay = 10 });

            await context.SaveChangesAsync();
        }

    }

}
