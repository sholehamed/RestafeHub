var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.CafeApp_Server>("cafeapp-server");

builder.Build().Run();
