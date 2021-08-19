using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AutoMapper.IoC.Api
{
    public static class IoCApi
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
