var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// `env` de�i�keni, uygulaman�n �al��ma ortam�n� (`IWebHostEnvironment`) temsil eder.
// Bu, ortam�n ad�n� (�rne�in, "Development", "Staging", "Production"), k�k dizin yolunu (`ContentRootPath`) ve di�er bilgileri i�erir.
var env = builder.Environment;
builder.Configuration.SetBasePath(env.ContentRootPath)
    .AddJsonFile("appsettings.json",optional:false) // Varsay�lan yap�land�rma dosyas� olan "appsettings.json" dosyas�n� ekliyoruz.
                                                    // `optional: false` ifadesi, bu dosyan�n bulunmas�n�n zorunlu oldu�unu belirtir.
                                                    // E�er dosya eksikse, uygulama ba�lat�l�rken hata verir.
    .AddJsonFile($"appsettings{env.EnvironmentName}.json",optional:true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
