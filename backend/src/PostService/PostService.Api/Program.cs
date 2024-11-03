using Microsoft.EntityFrameworkCore;
using PostService.Api.GraphQL.Mutation;
using PostService.Api.GraphQL.Query;
using PostService.Application;
using PostService.Infrastructure;
using PostService.Persistence;

var builder = WebApplication.CreateBuilder(args);
 
builder.Services
    .AddPersistenceServices(builder.Configuration)
    .AddInfrastructureServices()
    .AddApplicationServices();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddType(new UuidType());

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<PostDbContext>();
    dbContext.Database.Migrate();
}

app.UseHttpsRedirection();

app.MapGraphQL();

app.Run();