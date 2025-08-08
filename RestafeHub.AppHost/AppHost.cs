var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.RestafeHub_ApiServer>("restafehub-apiserver");

builder.Build().Run();
