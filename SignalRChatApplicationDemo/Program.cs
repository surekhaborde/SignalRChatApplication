using SignalRChatApplication.Hubs;
using SignalRChatApplicationDemo.DAL;
using System;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSignalR();
//Service.AddDbContext<UserDbContext>(options =>
//            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
//object value = builder.Services.AddDbContext<UserDbContext>(options =>
//{
//    //the change occurs here.
//    //builder.cofiguration and not just configuration
//    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
//}); 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapHub<ChatHub>("/ChatHub");

app.Run();
