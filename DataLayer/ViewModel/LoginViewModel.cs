using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DataLayer
{
  public  class LoginViewModel
    {

        [Display(Name = "نام کاربری ")]
        [Required(ErrorMessage = "لطفا{0} وارد کنید")]
        [MaxLength(200)]
        public string UserName { get; set; }

        [Display(Name = "کلمه ی عبور")]
        [Required(ErrorMessage = "لطفا{0} وارد کنید")]
        [MaxLength(200)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "مرا به خاطر بسپار")]
        public bool RememberMe { get; set; }
    }
}
