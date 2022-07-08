using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<EFChallenge.Data.EFChallengeDbContext>(optionsAction =>
{
    var connectionString = builder.Configuration.GetConnectionString("EFChallengeDB");
    optionsAction.UseSqlServer(connectionString, sqlServerOptionsAction => sqlServerOptionsAction.MigrationsAssembly("EFChallenge.Data"));

});
builder.Services.AddControllers();
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

app.UseHttpsRedirection();

//Commented because not using Authorization
//app.UseAuthorization();

app.MapControllers();

app.Run();
