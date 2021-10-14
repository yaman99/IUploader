using IUploader_Appilication.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUploader_Appilication
{
    public static class DependencyInjection
    {
            public static IServiceCollection AddAppilication(this IServiceCollection services)
            {
                services.AddScoped<IPersonIdentityService, PersonIdentityService>();
                return services;
            }
    }
}
