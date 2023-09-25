using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using MudBlazor.Services;
using PeliculasCFHN.ClienteBlazor;
using PeliculasCFHN.ClienteBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7207/api/") });

builder.Services.AddScoped<IGeneroService, GeneroService>();
builder.Services.AddScoped<IDirectorService, DirectorService>();
//builder.Services.AddScoped<IPeliculaService, PeliculaService>();

builder.Services.AddMudServices();  //importacin de los servicios de MudBlazor

await builder.Build().RunAsync();
