using MazakaNet.Models;
using MazakaNet.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MazakaNet.Controllers;

public class AccountController : Controller
{
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly UserManager<AppUser> _userManager;

    public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
        RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _roleManager = roleManager;
    }

    public async Task<IActionResult> Register(string? returnUrl = null)
    {
        if (!await _roleManager.RoleExistsAsync("Admin"))
        {
            await _roleManager.CreateAsync(new IdentityRole("Admin"));
            await _roleManager.CreateAsync(new IdentityRole("User"));
        }

        var listItems = new List<SelectListItem>();
        listItems.Add(new SelectListItem
        {
            Value = "Admin",
            Text = "Admin"
        });
        listItems.Add(new SelectListItem
        {
            Value = "User",
            Text = "User"
        });

        var registerViewModel = new RegisterViewModel();
        registerViewModel.RoleList = listItems;
        registerViewModel.ReturnUrl = returnUrl;
        return View(registerViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel registerViewModel, string? returnUrl = null)
    {
        registerViewModel.ReturnUrl = returnUrl;
        returnUrl = returnUrl ?? Url.Content("~/");
        if (ModelState.IsValid)
        {
            var user = new AppUser { Email = registerViewModel.Email, UserName = registerViewModel.UserName};
            var result = await _userManager.CreateAsync(user, registerViewModel.Password);
            if (result.Succeeded)
            {
                if (registerViewModel.RoleSelected != null && registerViewModel.RoleSelected.Length > 0 &&
                    registerViewModel.RoleSelected == "Admin")
                    await _userManager.AddToRoleAsync(user, "Admin");
                else
                    await _userManager.AddToRoleAsync(user, "User");
                await _signInManager.SignInAsync(user, false);
                return LocalRedirect(returnUrl);
            }

            ModelState.AddModelError("Password", "User could not be created. Password not unique enough");
        }

        var listItems = new List<SelectListItem>();
        listItems.Add(new SelectListItem
        {
            Value = "Admin",
            Text = "Admin"
        });
        listItems.Add(new SelectListItem
        {
            Value = "User",
            Text = "User"
        });

         registerViewModel.RoleList = listItems;
        return View(registerViewModel);
    }

    [HttpGet]
    public IActionResult Login(string? returnUrl = null)
    {
        var loginViewModel = new LoginViewModel();
        loginViewModel.ReturnUrl = returnUrl ?? Url.Content("~/");
        return View(loginViewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> LogOut()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }
}