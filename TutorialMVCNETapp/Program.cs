// Entry point of the application. Gives access to configurations, DI and other services.
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline. This determines how requests are processed by the app.
// If app is not in development environment, users are redirected to  /Home/Error page.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    // Additionaly enable HTTP Strict Transport Security to ensure secure HTTPS connections.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

// Map Static files like images, CSS and JS from wwwroot folder.
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    // Name of controller, function of that controller and optional id.
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
