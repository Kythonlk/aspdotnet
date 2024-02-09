/* var builder = WebApplication.CreateBuilder(args); */
/**/
/* builder.Services.AddEndpointsApiExplorer(); */
/* builder.Services.AddSwaggerGen(); */
/**/
/* var app = builder.Build(); */
/**/
/* if (app.Environment.IsDevelopment()) */
/* { */
/*     app.UseSwagger(); */
/*     app.UseSwaggerUI(); */
/* } */
/**/
/* app.UseHttpsRedirection(); */
/**/
/* var summaries = new[] */
/* { */
/*     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" */
/* }; */
/**/
/* app.MapGet("/we", () => */
/* { */
/*     var forecast =  Enumerable.Range(1, 5).Select(index => */
/*         new WeatherForecast */
/*         ( */
/*             DateOnly.FromDateTime(DateTime.Now.AddDays(index)), */
/*             Random.Shared.Next(-20, 55), */
/*             summaries[Random.Shared.Next(summaries.Length)] */
/*         )) */
/*         .ToArray(); */
/*     return forecast; */
/* }) */
/* .WithName("GetWeatherForecast") */
/* .WithOpenApi(); */
/**/
/**/
/* app.MapGet("/people", () => new[] */
/* { */
/*     new Person("Ana"), new Person("Filipe"), new Person("Emillia") */
/* }); */
/**/
/**/
/* app.Run(); */
/**/
/* record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary) */
/* { */
/*     public int TemperatureF => 32 + (int)(TemperatureC / 0.5556); */
/* } */
/**/
/* record Person(string Name); */

var app = WebApplication.Create(args);

app.MapGet("/", () => "Hello World!");


app.MapGet("/users/{userId}", 
    (int userId) => $"The user id is {userId}");


app.Run();
