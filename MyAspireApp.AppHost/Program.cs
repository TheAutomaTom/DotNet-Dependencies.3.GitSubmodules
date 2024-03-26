var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.MyAspireApp_ApiService>("apiservice");

builder.AddProject<Projects.MyAspireApp_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
