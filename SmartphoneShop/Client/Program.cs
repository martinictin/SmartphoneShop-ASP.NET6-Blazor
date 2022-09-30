global using SmartphoneShop.Shared;
global using System.Net.Http.Json;
global using SmartphoneShop.Shared.DTO;
global using SmartphoneShop.Client.Services.ProductService;
global using SmartphoneShop.Client.Services.CategoryService;
global using SmartphoneShop.Client.Services.AuthService;
global using Microsoft.AspNetCore.Components.Authorization;
global using SmartphoneShop.Client.Services.UserService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SmartphoneShop.Client;
using Blazored.LocalStorage;
using SmartphoneShop.Client.Services.CartService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, SmartphoneShop.Client.Services.CategoryService.UserService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IUserService, SmartphoneShop.Client.Services.UserService.UserService>();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider,CustomAuthStateProvider>();

await builder.Build().RunAsync();
