using Microsoft.AspNetCore.Builder;
using MyPieShop.Models;

var builder = WebApplication.CreateBuilder(args);

//Build my own services 
builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IPieRepository, MockPieRepository>();


//service configeration 
builder.Services.AddControllersWithViews();

var app = builder.Build();

// middleware 
app.UseStaticFiles();// it is static middleware component

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); //diagnostic middleware component
}

app.MapDefaultControllerRoute();//default control middleware component use in route


app.Run();
