using BlazorDbzPersonagem.Components;
using BlazorDbzPersonagem.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Registra o HttpClient apontando para a API do Dragon Ball
builder.Services.AddHttpClient<PersonagemService>(client =>
{
    client.BaseAddress = new Uri("https://dragonball-api.com/");
});

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

app.Run();
