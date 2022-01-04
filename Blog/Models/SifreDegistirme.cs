using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class SifreDegistirme
    {
        [Required]
        [DisplayName("Geçerli Şifre")]
        public string OldPassword { get; set; }
        [Required]
        [DisplayName("Yeni Şifre")]
        [StringLength(100,MinimumLength =5,ErrorMessage ="Şifreniz En az 5 karakter olmalıdır.")]
        public string NewPassword { get; set; }
        [Required]
        [DisplayName("Yeni Şifre Tekrarı")]
        [Compare("NewPassword",ErrorMessage ="Şifreler Eşleşmeli")]
        public string ConfirmPassword { get; set; }



    }
}