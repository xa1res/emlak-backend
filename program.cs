using PentaNest.Emlak.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// Swagger (opsiyonel ama yerinde dursun)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DataService (mock veriler buradan geliyor)
builder.Services.AddSingleton<DataService>();

// CORS: Angular lokal için izin ver
var allowedOrigin = builder.Configuration["FRONTEND_URL"] ?? "http://localhost:4200";
builder.Services.AddCors(o =>
{
    o.AddPolicy("frontend", p =>
        p.WithOrigins(allowedOrigin)
         .AllowAnyHeader()
         .AllowAnyMethod());
});

var app = builder.Build();

// Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// HTTP -> HTTPS yönlendirmeye şimdilik gerek yoksa kapat
// app.UseHttpsRedirection();

app.UseCors("frontend");

// Attribute-routed controller'ları map'le
app.MapControllers();

app.Run();
