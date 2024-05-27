﻿namespace NewsManagement.Endpoint.APIs;

using Swan.Core.Models;

public class Host : Model
{
    public static void Up(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder
        .ConfigureServices()
        .ConfigurePipelines();
        app.Run();
    }
}