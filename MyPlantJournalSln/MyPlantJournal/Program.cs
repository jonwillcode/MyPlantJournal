using Microsoft.EntityFrameworkCore;
using MyPlantJournal.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<PlantJournalDbContext>(opts =>
{
opts.UseSqlServer (
    builder.Configuration["ConnectionStrings:MyPlantJournalConnection"]);
});

builder.Services.AddScoped<IPlantJournalRepository, EFPlantJournalRepository>();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.UseStaticFiles();
app.MapDefaultControllerRoute();

SeedData.EnsurePopulated(app);

app.Run();
