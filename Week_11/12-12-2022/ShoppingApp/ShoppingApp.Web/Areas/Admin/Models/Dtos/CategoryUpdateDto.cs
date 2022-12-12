﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ShoppingApp.Web.Areas.Admin.Models.Dtos
{
    public class CategoryUpdateDto
    {
        public int Id { get; set; }

        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} boş bıraılmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0}, {1} karakterden kısa olmalıdır.")]
        [MaxLength(50, ErrorMessage = "{0}, {1} karakterden uzun olmalıdır.")]
        public string Name { get; set; }

        [DisplayName("Kategori Açıklaması")]
        [Required(ErrorMessage = "{0} boş bıraılmamalıdır.")]
        [MinLength(10, ErrorMessage = "{0}, {1} karakterden kısa olmalıdır.")]
        [MaxLength(500, ErrorMessage = "{0}, {1} karakterden uzun olmalıdır.")]
        public string Description { get; set; }

        [DisplayName("Kategori Url")]
        [Required(ErrorMessage = "{0} boş bıraılmamalıdır.")]
        public string Url { get; set; }
    }
}
