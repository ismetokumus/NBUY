using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Business.Concrete;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.EmailServices.Abstract;
using ShoppingApp.Web.EmailServices.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<IdentityContext>(options=>options.UseSqlite("Data Source=ShoppingApp.Db"));
builder.Services.AddDbContext<ShopAppContext>();

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<IdentityContext>()
    .AddDefaultTokenProviders();//�erez kullan�m� i�in taray�c� i�eriisnde login durumu i�in.-�ifre yenilemede g�nderilen mail de gizli bilgiler le doldurup kontrol etmek i�in.

builder.Services.Configure<IdentityOptions>(options =>
{
    #region PassworSettings
    options.Password.RequireDigit= true;//�ifre iinde mutlaka rakam bulusun.
    options.Password.RequireLowercase= true;//�ifre i�inde mutlaka k���k harf olsun
    options.Password.RequireUppercase= true;//�ifre i�inde mutlaka b�y�k harf olsun
    options.Password.RequiredLength= 6;//��fre en az 6 karakter olsun
    options.Password.RequireNonAlphanumeric= true;//�ifre i�inde alfa numerik karakterler (*,4,-,*,) bulunmas� zorunlu olsun

    #endregion

    #region LoginSettings
    options.Lockout.MaxFailedAccessAttempts= 5;//5kez hatal� hata giri�te hesap kitleniyor.
    options.Lockout.DefaultLockoutTimeSpan= TimeSpan.FromMinutes(5);//Kilitlen mi� hesab�n 5 dakika sonra tekrar deneyebilrisiniz.TimeSpan. dan sonra farkl� seenekler de var.

    #endregion

    #region UserSettings
    options.User.RequireUniqueEmail = true; //Benzersiz email adresi ile kay�t olunabilir yani daha �nce kullan�lm�� mail adresi kullan�lamaz.
    #endregion

    #region SignInSettings
    options.SignIn.RequireConfirmedEmail = false;//true ise email onay� aktiftir.
    options.SignIn.RequireConfirmedPhoneNumber= false;//true ise tel onay� aktiftir.
    #endregion

});

builder.Services.ConfigureApplicationCookie(options => 
{
    options.LoginPath = "/account/login";//E�er a��labilmesi i�in login olman�n zporunlu oldu�u bir istekle bulunurssa kullan�c�c�n y�nlendirilece�i sayfa buras� olacak.(account controlleridaki login action methodu)
    options.LogoutPath = "/account/logout";//Kullan�c� ��k�� yapt���nda y�nlendirilecek sayfa
    options.AccessDeniedPath= "/account/accessdenied";//Yetkisiz giri� s�ras�nda y�nlendirilecek sayfa
    options.SlidingExpiration = true;//varsay�lan cookie ya�am s�resi (20dk ) ya da ayarlanan ya�am s�resisnin her yeni istek s�ras�nda s�f�rlanarak yeniden ba�lamas�n� sa�lar.
    options.ExpireTimeSpan= TimeSpan.FromMinutes(5);//Ya�a�m s�resini ayarlar.
    options.Cookie = new CookieBuilder
    {
        HttpOnly= true,
        Name=".ShopingApp.Security.Cookie",
        SameSite=SameSiteMode.Strict//Sitemizi korumak ama�l� kopya sitesi sald�r�lar�ndan da korur.
    };
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<IEmailSender, SmtpEmailSender>(x => new SmtpEmailSender
    (
        "smtp.office65.com",587,true,"wissen_core@hotmail.com","Wissen123."
    ));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "products",
    pattern: "kategori/{categoryurl?}",
    defaults: new { controller = "Shop", action = "ProductList" }
    );

app.MapControllerRoute(
    name:"productdetails",
    pattern:"urunler/{producturl}",
    defaults: new {controller="Shop", action="ProductDetails"}
    );


app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"); ;

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
