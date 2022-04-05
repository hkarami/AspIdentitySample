using IdentitySample.Models.Accounts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySample.Controllers
{
    public class AccountController : Controller
    {
        #region [Fields]
        private readonly UserManager<IdentityUser> _userManager;
        #endregion

        #region [Ctor]
        public AccountController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        #endregion

        #region [Methods]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var newUser = new IdentityUser()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    EmailConfirmed = true
                };

                var createResult = await _userManager.CreateAsync(newUser);
                if (createResult.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                foreach(var err in createResult.Errors)
                {
                    ModelState.AddModelError("",err.Description);
                }
                
            }

            return View(model);
        }
        #endregion
    }
}
