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
    .AddDefaultTokenProviders();//Çerez kullanýmý için tarayýcý içeriisnde login durumu için.-þifre yenilemede gönderilen mail de gizli bilgiler le doldurup kontrol etmek için.

builder.Services.Configure<IdentityOptions>(options =>
{
    #region PassworSettings
    options.Password.RequireDigit= true;//Þifre iinde mutlaka rakam bulusun.
    options.Password.RequireLowercase= true;//Þifre içinde mutlaka küçük harf olsun
    options.Password.RequireUppercase= true;//Þifre içinde mutlaka büyük harf olsun
    options.Password.RequiredLength= 6;//ÞÝfre en az 6 karakter olsun
    options.Password.RequireNonAlphanumeric= true;//Þifre içinde alfa numerik karakterler (*,4,-,*,) bulunmasý zorunlu olsun

    #endregion

    #region LoginSettings
    options.Lockout.MaxFailedAccessAttempts= 5;//5kez hatalý hata giriþte hesap kitleniyor.
    options.Lockout.DefaultLockoutTimeSpan= TimeSpan.FromMinutes(5);//Kilitlen miþ hesabýn 5 dakika sonra tekrar deneyebilrisiniz.TimeSpan. dan sonra farklý seenekler de var.

    #endregion

    #region UserSettings
    options.User.RequireUniqueEmail = true; //Benzersiz email adresi ile kayýt olunabilir yani daha önce kullanýlmýþ mail adresi kullanýlamaz.
    #endregion

    #region SignInSettings
    options.SignIn.RequireConfirmedEmail = false;//true ise email onayý aktiftir.
    options.SignIn.RequireConfirmedPhoneNumber= false;//true ise tel onayý aktiftir.
    #endregion

});

builder.Services.ConfigureApplicationCookie(options => 
{
    options.LoginPath = "/account/login";//Eðer açýlabilmesi için login olmanýn zporunlu olduðu bir istekle bulunurssa kullanýcýcýn yönlendirileceði sayfa burasý olacak.(account controlleridaki login action methodu)
    options.LogoutPath = "/account/logout";//Kullanýcý çýkýþ yaptýðýnda yönlendirilecek sayfa
    options.AccessDeniedPath= "/account/accessdenied";//Yetkisiz giriþ sýrasýnda yönlendirilecek sayfa
    options.SlidingExpiration = true;//varsayýlan cookie yaþam süresi (20dk ) ya da ayarlanan yaþam süresisnin her yeni istek sýrasýnda sýfýrlanarak yeniden baþlamasýný saðlar.
    options.ExpireTimeSpan= TimeSpan.FromMinutes(5);//Yaþaþm süresini ayarlar.
    options.Cookie = new CookieBuilder
    {
        HttpOnly= true,
        Name=".ShopingApp.Security.Cookie",
        SameSite=SameSiteMode.Strict//Sitemizi korumak amaçlý kopya sitesi saldýrýlarýndan da korur.
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
