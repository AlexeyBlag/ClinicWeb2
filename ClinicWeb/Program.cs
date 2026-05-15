using  ClinicWeb.Components;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using  ClinicWeb.Components;
using  ClinicWeb.Data;
using  ClinicWeb.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<IPetRepository, PetRepository>();


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? "Data Source=vetclinic.db";

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(connectionString));


builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IVeterinarianRepository, VeterinarianRepository>();
builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();


builder.Services.AddValidatorsFromAssemblyContaining<Program>();


var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();


using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await ClinicWeb.Data.DbSeeder.SeedAsync(dbContext);
}


app.Run();