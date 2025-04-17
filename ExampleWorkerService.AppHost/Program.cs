var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ExampleWorkerService>("exampleworkerservice");

builder.AddProject<Projects.ExampleWorkerServiceTwo>("exampleworkerservicetwo");

//TODO - Can not get this to work
//var container = builder.AddDockerfile(
//    "exampletwo", "../ExampleWorkerServiceTwo");

builder.Build().Run();
