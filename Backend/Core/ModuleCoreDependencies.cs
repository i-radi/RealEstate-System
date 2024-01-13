using Core.Behaviors;
using Core.Services.Abstracts;
using Core.Services.Implementations;
using Core.Services.ThirdParty.EmailService;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Core;

public static class ModuleCoreDependencies
{
    public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
    {
        //Configuration Of Mediator
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        //Configuration Of Automapper
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        // Get Validators
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        //Configuration Of Services
        services.AddTransient<IAuthenticationService, AuthenticationService>();
        services.AddTransient<IAuthorizationService, AuthorizationService>();
        services.AddTransient<ICurrentUserService, CurrentUserService>();
        services.AddTransient<IPropertyService, PropertyService>();
        services.AddTransient<IFileService, FileService>();
        services.AddTransient<IUserService, UserService>();
        //Configuration Of Third Party Services
        services.AddTransient<IEmailsService, EmailsService>();
        return services;
    }

}