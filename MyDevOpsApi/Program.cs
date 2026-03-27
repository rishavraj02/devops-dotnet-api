using MyDevOpsApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Adding services to the container.

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddSingleton<UserService>();

var app = builder.Build();

// Configuring the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.MapControllers();

// Redirecting the root URL (/) to the Swagger UI (/swagger)
app.MapGet("/", (HttpContext context) => 
{
    context.Response.Redirect("/swagger");
    return Task.CompletedTask;
});

app.Run();
