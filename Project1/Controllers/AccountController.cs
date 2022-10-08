using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project1.ViewModels;

namespace Project1.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class AccountController : ControllerBase
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<bool> Login(string returnUrl = null)
        {
            return true;
        }
        [HttpPost]
        public async Task<bool> Login(LoginViewModel model, string returnUrl = null)
        {


            return true;
        }
        [HttpGet]
        public IActionResult Register(string returnUrl = null)
        {
            RegisterViewModel registerViewModel = new();
            registerViewModel.ReturnUrl = returnUrl;
            return JsonResult(registerViewModel);
        }
        [HttpPost]
        public async Task<bool> Register(RegisterViewModel model, string returnUrl = null)
        {
            return true;
        }
        public async Task<bool> Logout()
        {
            await _signInManager.SignOutAsync();
            return true;
        }
        
        

    }
}
