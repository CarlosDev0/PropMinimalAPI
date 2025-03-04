var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/saludoGet", () => "Bienvenidos curso");
app.MapPost("/saludoPost", () => "Response Post");
app.MapGet("/saludoOk", () => Results.Ok("Bienvenidos curso"));
app.MapPut("/saludoNotFound", () => Results.NotFound("Not Found"));
app.MapDelete("/saludoBadRquest", () => Results.BadRequest("Response Post"));
app.MapGet("/saludoWithParam/{id}", (int id) => Results.Ok($"El id es: {id}"));
app.MapGet("/saludoWithParamType/{id:int}", (int id) => Results.Ok($"El id es: {id}"));
app.UseHttpsRedirection();
app.Run();


//Continue: https://www.youtube.com/watch?v=7U9KzlTktLg
