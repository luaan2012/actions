using MassTransit;

var builder = WebApplication.CreateBuilder();

builder.Services.AddMassTransit(x =>
{
    x.AddConsumers(typeof(Program).Assembly);
    x.UsingInMemory((context, cfg) =>
    {
        cfg.ConfigureEndpoints(context);
    }); 
});

builder.Services.AddHostedService<PingPublisher>();

var app = builder.Build();

app.Run();
