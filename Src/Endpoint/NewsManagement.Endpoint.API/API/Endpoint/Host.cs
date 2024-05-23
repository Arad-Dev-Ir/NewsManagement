﻿namespace NewsManagement.Endpoint.APIs;

using Swan.Core.Models;

// Hosting
public class Host : Model
{
    public static void Up(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();
        //.ConfigureServices()
        //.ConfigurePipelines();
        app.Run();
    }
}