var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ExampleWorkerService>("exampleworkerservice");

//builder.AddProject<Projects.ExampleWorkerServiceTwo>("exampleworkerservicetwo");

var container = builder.AddDockerfile(
    "exampletwo", "../ExampleWorkerServiceTwo");

builder.Build().Run();
