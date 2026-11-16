var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//What is CORS
//CORS stands for Cross-Origin Resource Sharing
//you can think of "origin" as our protocal + port like http://127.0.0.1:5500
//only browsers check CORS, postman ignores it

builder.Services.AddCors(options =>
{
    options.AddPolicy("Frontend", policy =>
    {
        //Here we are going to let our app know which origins and request methods are allowed
        policy.AllowAnyOrigin()
        //Allows any request header like content-type
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("Frontend");

app.MapControllers();

app.Run();
