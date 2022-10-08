using System.Security.Claims;
using MazakaNet.Models;
using Microsoft.AspNetCore.Identity;

namespace MazakaNet.Services
{
    public class AccountServices : IAccountServices
    {

        
        public static SignInManager<AppUser> _signInManager;
        public static UserManager<AppUser> _userManager;
        public static void Configure(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

    }
    
}