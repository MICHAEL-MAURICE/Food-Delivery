using System.ComponentModel.DataAnnotations;

namespace food_ordering_app.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Username or Email Required")]
        [Display(Name ="Email or UserName")]
        public string UserLogin { get; set; }

        [Required(ErrorMessage ="Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
