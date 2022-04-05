using System.ComponentModel.DataAnnotations;

namespace IdentitySample.Models.Accounts
{
    public class RegisterModel
    {
        #region [Properties]
        [Required]
        [Display(Name = "User Name:")]
        public string   UserName{ get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address:")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password))]
        [Display(Name = "Confirm Password:")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        #endregion
    }
}
