using Microsoft.AspNetCore.Rewrite;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Custom middleware code - logs all requests in detail
app.Use(async (context, next) => {
    await next(); // Call next middleware
    Console.WriteLine($"{context.Request.Method} {context.Request.Path} {context.Response.StatusCode}"); // Avoid all redirects having status code 200
});

app.UseRewriter(new RewriteOptions().AddRedirect("history", "about"));

app.MapGet("/", () => "Welcome to Contoso!");

app.MapGet("/about", () => "Contoso was founded in 2000.");

app.Run();
