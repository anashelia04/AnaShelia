using FluentValidation;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using WebApplication2.Model;
using WebApplication2.Services;
using WebApplication2.Validators;
using WebApplication2.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<UserService>();
builder.Services.AddTransient<IValidator<User>, UserValidator>();

var app = builder.Build();

app.UseMiddleware<ErrorHandlingMiddleware>();

var supportedCultures = new[] { "en-US", "ka-GE" };
var localizationOptions = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture("en-US"),
    SupportedCultures = supportedCultures.Select(c => new CultureInfo(c)).ToList(),
    SupportedUICultures = supportedCultures.Select(c => new CultureInfo(c)).ToList()
};
app.UseRequestLocalization(localizationOptions);

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();