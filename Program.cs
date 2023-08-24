using JWPub.Api.Repositories;
using JWPub.Api.Routes;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IPublisherRepository,PublisherRepository>();
builder.Services.AddSingleton<ICongregationRepository,CongregationRepository>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.PublisherRouteEndpoints();
app.CongregationRouteEndpoints();
app.Run();
