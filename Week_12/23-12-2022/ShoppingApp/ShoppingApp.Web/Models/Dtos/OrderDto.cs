using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Web.Models.Dtos
{
    public class OrderDto
    {
        [DisplayName("Ad")]
        [Required(ErrorMessage="{0} alanı boş bırakılmamalıdır.")]
        public string FirstName { get; set; }

        [DisplayName("Soyad")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        public string LastName { get; set; }

        [DisplayName("Adres")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        public string Address { get; set; }

        [DisplayName("Şehir")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        public string City { get; set; }

        [DisplayName("Telefon")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Kartın Üzerindeki Ad Soyad")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        public string CardName { get; set; }

        [DisplayName("Kart Numarası")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        [DataType(DataType.CreditCard)]
        public string CarNumber { get; set; }

        [DisplayName("Son kullanma Ay")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        public string ExpirationMonth { get; set; }

        [DisplayName("Son kullanma Yıl")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        public string ExpirationYear { get; set; }

        [DisplayName("Kart CVC")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        public string Cvc { get; set; }
        public CardDto CardDto { get; set; }
    }
}
