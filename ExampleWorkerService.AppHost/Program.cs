var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ExampleWorkerService>("exampleworkerservice");

builder.AddProject<Projects.ExampleWorkerServiceTwo>("exampleworkerservicetwo");

builder.Build().Run();
