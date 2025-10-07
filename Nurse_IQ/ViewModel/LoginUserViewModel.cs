using System.ComponentModel.DataAnnotations;

namespace Nurse_IQ.ViewModel
{
    public class LoginUserViewModel
    {
        [Required(ErrorMessage = "*")]
        [EmailAddress(ErrorMessage = "يرجى إدخال بريد إلكتروني صالح")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "تذكرني")]
        public bool RememberMe { get; set; }
    }
}
