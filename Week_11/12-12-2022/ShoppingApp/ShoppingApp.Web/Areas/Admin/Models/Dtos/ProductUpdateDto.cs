using ShoppingApp.Entity.Concrete;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ShoppingApp.Web.Areas.Admin.Models.Dtos
{
    public class ProductUpdateDto
    {
        public int Id { get; set; }


        [DisplayName("Ürün Adı")]
        [Required(ErrorMessage = "{0} boş bıraılmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0}, {1} karakterden kısa olmalıdır.")]
        [MaxLength(50, ErrorMessage = "{0}, {1} karakterden uzun olmalıdır.")]
        public string Name { get; set; }

        [DisplayName("Fiyatı")]
        [Required(ErrorMessage = "{0} boş bıraılmamalıdır.")]
        public decimal? Price { get; set; }

        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "{0} boş bıraılmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0}, {1} karakterden kısa olmalıdır.")]
        [MaxLength(500, ErrorMessage = "{0}, {1} karakterden uzun olmalıdır.")]
        public string Description { get; set; }

        [DisplayName("Ürün Resmi")]
        [Required(ErrorMessage = "{0} seçilmelidir.")]
        public IFormFile ImageFile { get; set; }

        [DisplayName("Ana Sayfa Ürünü")]
        public bool IsHome { get; set; }

        [DisplayName("Onaylı Ürünü")]
        public bool IsApproved { get; set; }

        [DisplayName("Kategoriler")]
        public List<Category> Categories { get; set; }

        [Required(ErrorMessage = "En az bir kategori seçilmelidir.")]
        public int[] SelectedCategoryIds { get; set; }
        public string ImageUrl { get; set; }
    }
}
