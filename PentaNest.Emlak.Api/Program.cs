// using deyimleri dosyanın en üstünde olmalıdır.
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("http://localhost:4200") 
                    .AllowAnyHeader()
                    .AllowAnyMethod();
        });
});

builder.Services.AddAuthorization();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors("AllowSpecificOrigin");

app.UseAuthorization();

app.MapControllers();

var ilanlar = new Ilan[]
{
    new Ilan("1", "https://via.placeholder.com/400x300", "Lüks Daire", 1500000, "Kadıköy, İstanbul", "Emlak Acentesi", "Satılık", 120, "3+1"),
    new Ilan("2", "https://via.placeholder.com/400x300", "Geniş Villa", 8500000, "Bodrum, Muğla", "Emlak Acentesi", "Satılık", 300, "5+2"),
    new Ilan("3", "https://via.placeholder.com/400x300", "Merkezi Konumda Dükkan", 50000, "Şişli, İstanbul", "Emlak Acentesi", "Kiralık", 80, null),
    new Ilan("4", "https://via.placeholder.com/400x300", "Boğaz Manzaralı Yalı Dairesi", 25000000, "Beşiktaş, İstanbul", "Emlak Acentesi", "Satılık", 400, "4+1")
};

app.MapGet("/api/ilanlar", () => Results.Ok(ilanlar))
.WithName("GetIlanlar");


app.Run();app.Run();

public record Ilan(
    string Id,
    string ImageURL,
    string Title,
    int Price,
    string Location,
    string Emlakci,
    string Durum,
    int M2,
    string? OdaSayisi 
);