using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreIdentityMysql.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIdentityMysql.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Account")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signManager;

        public AccountController(UserManager<ApplicationUser> userManager,
                    SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signManager = signInManager;
        }



    }
}