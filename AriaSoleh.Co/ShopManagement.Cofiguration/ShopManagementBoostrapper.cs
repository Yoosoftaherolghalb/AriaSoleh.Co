using _01_Query.Contracts.CompanyProject;
using _01_Query.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopManagement.Application;
using ShopManagement.Application.Contracts.CompanyProject;
using ShopManagement.Domain.CompanyProjectAgg;
using ShopManagement.Infrastructure.EFCore;
using ShopManagement.Infrastructure.EFCore.Repository;

namespace ShopManagement.Cofiguration
{
    public class ShopManagementBoostrapper
    {
        public static void Configure(IServiceCollection service, string connectionString)
        {
            service.AddTransient<ICompanyProjectApplication, CompanyProjectApplication>();
            service.AddTransient<ICompanyProjectRepository, CompanyProjectRepository>();
            service.AddTransient<ICompanyProjectApplication, CompanyProjectApplication>();
            service.AddTransient<ICompanyProjectQuery, CompanyProjectQuery>();

            service.AddDbContext<Context>(x => x.UseSqlServer(connectionString));
        }

    }
}