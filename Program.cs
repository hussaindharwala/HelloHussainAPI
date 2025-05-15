var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure CORS
app.UseCors("AllowAll");

// Simple API endpoint
app.MapGet("/api/hello", () => "Hello Hussain");

app.Run();
