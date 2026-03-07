using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace ShippingOrderService.Web.Configuration;

public static class ValidationConfiguration
{
    public static IServiceCollection AddValidation(this IServiceCollection services)
    {
        services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter = true);
        services.AddValidatorsFromAssemblyContaining<Program>();
        return services;
    }
}