﻿using DsrProject.Common;

namespace DsrProject.Api.Configuration
{

    public static class ControllerAndViewsConfiguration
    {
        public static IServiceCollection AddAppControllerAndViews(this IServiceCollection services)
        {
            //services
            //    .AddRazorPages();

            services
                .AddControllers()
                .AddNewtonsoftJson(options => options.SerializerSettings.SetDefaultSettings())
                .AddValidator();

            return services;
        }

        public static IEndpointRouteBuilder UseAppControllerAndViews(this IEndpointRouteBuilder app)
        {
            //app.MapRazorPages();
            app.MapControllers();

            return app;
        }
    }
}