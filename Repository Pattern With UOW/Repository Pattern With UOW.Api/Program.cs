using Microsoft.EntityFrameworkCore;
using Repository_Pattern_With_UOW.Core;
using Repository_Pattern_With_UOW.Core.Interfaces;
using Repository_Pattern_With_UOW.EF;
using Repository_Pattern_With_UOW.EF.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(
                 builder.Configuration.GetConnectionString("DefaultConnection"),
             b=>b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
));

//builder.Services.AddTransient(typeof(IBaseRepository<>),typeof(BaseRepository<>));
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
