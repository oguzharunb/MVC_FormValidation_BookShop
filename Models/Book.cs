using System.ComponentModel.DataAnnotations;

namespace MVC_FormValidation_BookShop.Models
{
    public class Book
    {
        [Required(ErrorMessage = "Kitap adı alanı boş geçilemez")]
        [Display(Name = "Kitabın İsmi")]
        [MinLength(5),MaxLength(50)]
        public string? BookName { get; set; }

        [Required(ErrorMessage = "Yazar adı lanı boş geçilemez")]
        [Display(Name = "Yazarı")]
        [MinLength(5),MaxLength(50)]
        public string? Author { get; set; }
        [Required(ErrorMessage = "Kitap alanı boş geçilemez")]
        [Range(5,1000,ErrorMessage = "Sayfa Sayısı 5 ile 1000 arasında olmalıdır.")]
        public int? NumberofPages { get; set; }
        [Required(ErrorMessage = "Kitap adı alanı boş geçilemez")]
        [Range(1900,2022,ErrorMessage = "Basım Yılı tarihi 1900-2022 arasında olmalıdır.")]
        public int? YearofPublication { get; set; }

    }
}
