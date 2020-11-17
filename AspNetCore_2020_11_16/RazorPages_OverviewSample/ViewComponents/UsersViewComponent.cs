using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService;

namespace RazorPages_OverviewSample.ViewComponents
{
    public class UsersViewComponent : ViewComponent
    {
        private IUserService _userService;

        public UsersViewComponent(IUserService service)
        {
            _userService = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var users = await _userService.GetUsersAsync();
            return View(users);
        }
    }
}
