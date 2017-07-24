using System.ComponentModel.DataAnnotations;

namespace AspNetNote.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Please Input User ID")]
        public string UserId { get; set; }
      
        [Required(ErrorMessage ="Please Input User Password")]
        public string UserPassword { get; set; }
    }
}
