var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// `env` deðiþkeni, uygulamanýn çalýþma ortamýný (`IWebHostEnvironment`) temsil eder.
// Bu, ortamýn adýný (örneðin, "Development", "Staging", "Production"), kök dizin yolunu (`ContentRootPath`) ve diðer bilgileri içerir.
var env = builder.Environment;
builder.Configuration.SetBasePath(env.ContentRootPath)
    .AddJsonFile("appsettings.json",optional:false) // Varsayýlan yapýlandýrma dosyasý olan "appsettings.json" dosyasýný ekliyoruz.
                                                    // `optional: false` ifadesi, bu dosyanýn bulunmasýnýn zorunlu olduðunu belirtir.
                                                    // Eðer dosya eksikse, uygulama baþlatýlýrken hata verir.
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
