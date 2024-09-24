# Blazor 123 - an Aspire project

## How I started
Within Rider, create a new solution using the Blazor App template. Don't select to keep the project in the same directory, because you want the solution directory to contain separate project directories.

Then add the ServiceDefaults for logging and other metrics. Do this by adding another project to the solution, using the Aspire > ServiceDefaults template. Then right-click the Blazor project and select Add > Reference, and select the ServiceDefaults project. That sets things up so that the Blazor project can use the ServiceDefaults project. Then, within the Blazor project's Program.cs file, just below `var builder = WebApplication.CreateBuilder(args);` add the following line:
```
builder.AddServiceDefaults();
```
And, just below `var app = builder.Build();`, add the following line:
```
app.MapDefaultEndpoints();
```

Next, set up Aspire so you get a nice dashboard and single entry point for the solution. Right-click on the solution directory and add a new project, using the Aspire > App Host template. Then right-click on the AppHost directory and Add > Reference, and select the Blazor project. Then, within the AppHost project's Program.cs file, just below `var builder = DistributedApplication.CreateBuilder(args);` add the following line:
```
var web = builder.AddProject<Projects.Blazor123>("Blazor123");
```

Now start the App Host project and you should be given a dashboard that contains the Blazor project, along with traces, logging, etc.

Add an API, by adding another project to the solutions using the Web > Web Api template. Again, add the reference to this by right-clicking on the App Host project. Start the solution again, and it should appear in the dashboard alongside the Blazor project.














## Problems
Issues with the SSL? Try:
```
dotnet dev-certs https --trust
```
And that should do you.

