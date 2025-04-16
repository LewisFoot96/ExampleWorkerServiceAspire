var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ExampleWorkerService>("exampleworkerservice");

builder.Build().Run();
