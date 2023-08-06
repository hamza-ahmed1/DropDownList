var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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

#region Summary
/*
 * DropDown List method 1:
 * crate an enum in controller and get its value by html tag helpers:
 * DropDown List method 2:
 * by creating select list item: in  action method :
 * 
 * Method of asp.net core create by tag helper:
 *               <select name="Gender" asp-items="@ViewBag.Gender">
                 <option value="">Select Gender</option>
                 </select>
 * 
 * 
 */
#endregion