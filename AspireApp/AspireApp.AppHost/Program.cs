var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedisContainer("rediscache");

var api = builder.AddProject<Projects.WebAPI>("webapi");

builder.AddProject<Projects.WebApp>("webapp")
    .WithReference(api)
    .WithReference(cache);

builder.Build().Run();
