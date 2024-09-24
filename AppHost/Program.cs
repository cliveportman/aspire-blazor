var builder = DistributedApplication.CreateBuilder(args);
var web = builder.AddProject<Projects.Blazor123>("Blazor123", launchProfileName: "https");
var api = builder.AddProject<Projects.WebApi>("WebApi", launchProfileName: "https");

builder.Build().Run();