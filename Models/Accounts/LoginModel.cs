using System.ComponentModel.DataAnnotations;

namespace IdentitySample.Models.Accounts
{
    public class LoginModel
    {
        #region [Properties]
        [Required]
        [Display(Name = "User Name:")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Password:")]
        public string Password { get; set; }

        [Display(Name = "Remember Me:")]
        public bool RememberMe { get; set; }
        #endregion
    }
}
