using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Nurse_IQ.Models;
using Nurse_IQ.ViewModel;
using System.Security.Claims;

namespace Nurse_IQ.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<applicationUser> userManager;
        private readonly SignInManager<applicationUser> signInManager;

        public AccountController
            (UserManager<applicationUser> userManager, SignInManager<applicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        //public IActionResult Register()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Register()
        //{
        //    return View();           
        //}

        public IActionResult Login()
        {
            return View("Login");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]//requets.form['_requetss]
        public async Task<IActionResult> SaveLogin(LoginUserViewModel userViewModel)
        {
            if (ModelState.IsValid == true)
            {
                //check found 
                applicationUser appUser =
                    await userManager.FindByEmailAsync(userViewModel.Email);
                if (appUser != null)
                {
                    bool found =
                         await userManager.CheckPasswordAsync(appUser, userViewModel.Password);
                    if (found == true)//create cookie
                    {
                        //List<Claim> Claims = new List<Claim>();
                        //Claims.Add(new Claim("UserAddress", appUser.Address));

                        //await signInManager.SignInWithClaimsAsync(appUser, userViewModel.RememberMe, Claims);
                        await signInManager.SignInAsync(appUser, userViewModel.RememberMe);
                        return RedirectToAction("Index", "Home");
                    }

                }
                ModelState.AddModelError("", "Email OR Password Is Not Valid");
                //create cookie
            }
            return View("Login", userViewModel);
        }

        public async Task<IActionResult> SignOut()
        {
            await signInManager.SignOutAsync();//expire or damage the cookie 
            return View("Login");
        }

    }
}
