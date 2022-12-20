using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.Areas.Admin.Models.Dtos;

namespace ShoppingApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _usermanager;
        private readonly RoleManager<Role> _rolemanager;

        public UserController(UserManager<User> usermanager, RoleManager<Role> rolemanager)
        {
            _usermanager = usermanager;
            _rolemanager = rolemanager;
        }

        public IActionResult Index()
        {
            List<UserDto> users = _usermanager.Users.Select(u => new UserDto
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                UserName = u.UserName,
                Email = u.Email,
                EmailConfirmed = u.EmailConfirmed,
            }).ToList();
            ViewBag.SelectMenu = "User";
            ViewBag.Title = "Kullanıcılar";
            return View(users);
        }
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(UserCreateDto userCreateDto)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    FirstName = userCreateDto.FirstName,
                    LastName = userCreateDto.LastName,
                    UserName = userCreateDto.UserName,
                    Email = userCreateDto.Email,
                    EmailConfirmed = userCreateDto.EmailConfirmed,
                };
                var result = await _usermanager.CreateAsync(user,"Qwe123.");
                return RedirectToAction("Index", "User");
            }
            return View(userCreateDto);
        }
    }
}
