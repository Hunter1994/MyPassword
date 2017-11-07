using System.Collections.Generic;
using MyPassword.Roles.Dto;
using MyPassword.Users.Dto;

namespace MyPassword.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}