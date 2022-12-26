using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Concrete.EfCore.Contexts;

namespace ShoppingApp.Web.Extensions
{
    public static class MigrationManager//Extensions metodları static olmalı
    {
        public static IHost UpdateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var shopAppContext = scope.ServiceProvider.GetRequiredService<ShopAppContext>())
                {
                    try
                    {
                        shopAppContext.Database.Migrate();//Bu komut enüz işlenmemiş migrationları alır ve database update işlemine tabi tutar.
                    }
                    catch (Exception)
                    {
                        //Hataların tutulduğu loglar burada hazırlanıyor.
                        throw;
                    }

                }
            }
            return host;
        }
    }
}
