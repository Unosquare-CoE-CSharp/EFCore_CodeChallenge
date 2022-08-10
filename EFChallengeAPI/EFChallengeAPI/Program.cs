using EFChallenge.Data;
using EFChallenge.Services.DI;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//Register services with Dependency Injection
ServiceDI.RegisterDI(builder.Services);

//Connection to BD
builder.Services.AddDbContext<EFChallengeContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("EFChallengeConnection"))
);

var app = builder.Build();

//Initialize the BD automatic from migration
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<EFChallengeContext>();
    context.Database.Migrate();
}

//AppDbInitializer.Seed(app);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
