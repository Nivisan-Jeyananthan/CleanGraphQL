using FluentValidation;
using Mediator.Api.GraphQL;
using Mediator.Application;
using Mediator.Application.Common;
using Mediator.Application.Services.Commands;
using Mediator.Application.Services.Queries;
using Mediator.Core.Interfaces.Repositories.Commands;
using Mediator.Core.Interfaces.Repositories.Queries;
using Mediator.Core.Interfaces.Services.Commands;
using Mediator.Core.Interfaces.Services.Queries;
using Mediator.Infrastructure.Data;
using Mediator.Infrastructure.Repositories.Commands;
using Mediator.Infrastructure.Repositories.Queries;
using Mediator.Shared.Mapping;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

#region DbSetup
services.AddDbContextFactory<ApplicationDbContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("UserDb"), b => b.MigrationsAssembly("Mediator.Api"));
    options.EnableServiceProviderCaching(false);
    options.EnableSensitiveDataLogging();
});

#endregion

#region Setup_DI
builder.Services.AddAutoMapper(typeof(UserMappingProfile));
services.AddTransient<IUserCommandService, UserCommandService>();
services.AddTransient<IUserCommandRepository, UserCommandRepository>();

services.AddTransient<IUserQueryService, UserQueryService>();
services.AddTransient<IUserQueryRepository, UserQueryRepository>();
services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

services.AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>();
services.AddMediatR(typeof(IApplicationAssemblyMarker));
services.AddValidatorsFromAssemblyContaining(typeof(IApplicationAssemblyMarker));
#endregion

var app = builder.Build();
app.MapGraphQL();
app.Run();
