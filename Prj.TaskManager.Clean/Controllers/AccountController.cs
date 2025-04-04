using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.Services;
using TaskManager.Core.DTOs;

namespace Prj.TaskManager.Clean.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserService _userService;
        public AccountController(UserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Login(LoginDTO login)
        {
            var result = await _userService.Authenticate(login.UserName, login.Password);
            if (result)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(login);
        }
    }
}
