var builder = DistributedApplication.CreateBuilder(args);
var web = builder.AddProject<Projects.Blazor123>("Blazor123");
var api = builder.AddProject<Projects.WebApi>("WebApi");

builder.Build().Run();