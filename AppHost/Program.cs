var builder = DistributedApplication.CreateBuilder(args);
var web = builder.AddProject<Projects.Blazor123>("Blazor123");

builder.Build().Run();