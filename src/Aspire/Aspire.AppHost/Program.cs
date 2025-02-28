var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BookShop_WebApi>("webapi");


builder.Build().Run();
