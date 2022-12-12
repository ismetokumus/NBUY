using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Core
{
    public static class Jobs //new yapmamak için static yapıyoruz
    {
        public static string InitUrl(string url)
        {
            /*Bu metod kendisine gelen url değişkeninin içindeki 
                * 1) Türkçe karakterlerin yerine latin alfabesindeki karşılıklarını koyacak
                * 2) Latin alfabesine çevrilirken problem çıkaran  İ-i, ı-i gibi dönüştürmeleri yapacak
                * 3) boşluk yerine - konulacak
             */
            //sorunlu karakterler
            #region SorunluKarakterler
            url = url.Replace("I", "i");
            url = url.Replace("İ", "i");
            url = url.Replace("ı", "i");
            #endregion

            url = url.ToLower();
            #region TürkçeDönüşüm
            url = url.Replace("ö", "o");
            url = url.Replace("ü", "u");
            url = url.Replace("ş", "s");
            url = url.Replace("ç", "c");
            url = url.Replace("ğ", "g");
            #endregion

            #region YanlışKarakterDönüşümü
            url = url.Replace(" ", "-");
            url = url.Replace(".", "");
            url = url.Replace("/", "");
            url = url.Replace("\"", "");
            url = url.Replace("'", "");
            url = url.Replace("(", "");
            url = url.Replace(")", "");
            url = url.Replace("[", "");
            url = url.Replace("]", "");
            url = url.Replace("{", "");
            url = url.Replace("}", "");
            #endregion

            return url;


        }
        
        public static string UploadImage(IFormFile image)
        {
            var extension= Path.GetExtension(image.FileName);
            var randomName = $"{Guid.NewGuid()}{extension}";
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", randomName);
            using (var stream = new FileStream(path,FileMode.Create))
            {
                image.CopyTo(stream);
            }
            return randomName;
        }
    }
}
