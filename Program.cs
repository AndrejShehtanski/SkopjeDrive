using Microsoft.AspNetCore.Localization;
using SkopjeDrive.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.Configure<ContactEmailOptions>(
    builder.Configuration.GetSection(ContactEmailOptions.SectionName));
builder.Services.AddTransient<IContactEmailSender, SmtpContactEmailSender>();

var app = builder.Build();

// Multilingual support: EN / MK, selected via a cookie (see LanguageController)
var supportedCultures = new[] { "en", "mk" };
app.UseRequestLocalization(new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures));

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
