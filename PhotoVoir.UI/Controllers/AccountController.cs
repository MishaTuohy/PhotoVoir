using Firebase.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PhotoVoir.Domain.Entities.Users.Customer;
using PhotoVoir.Domain.Entities.Users.Photographer;
using System;
using System.Threading.Tasks;
using Microsoft.Owin.Security.Cookies;
using Okta.AspNet;

namespace PhotoVoir.UI.Controllers
{
    public class AccountController : Controller
    {
        private static string ApiKey = "";
        private static string Bucket = "";

        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            if (!HttpContext.User.Identity.IsAuthenticated)
            {
                HttpContext.GetOwinContext().Authentication.Challenge(
                    OktaDefaults.MvcAuthenticationType);
                return new HttpUnauthorizedResult();
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SignUp(Customer customer)
        {
            try
            {
                var auth = new FirebaseAuthProvider(new FirebaseConfig(ApiKey));

                var a = await auth.CreateUserWithEmailAndPasswordAsync(customer.Email, customer.Password, customer.UserName, true);
                ModelState.AddModelError(string.Empty, "Please Verify your email then login Plz.");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SignUp(Photographer photographer)
        {
            try
            {
                var auth = new FirebaseAuthProvider(new FirebaseConfig(ApiKey));

                var a = await auth.CreateUserWithEmailAndPasswordAsync(photographer.Email, photographer.Password, photographer.UserName, true);
                ModelState.AddModelError(string.Empty, "Please Verify your email then login Plz.");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }

            return View();
        }
    }
}
