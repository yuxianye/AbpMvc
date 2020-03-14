using System.Collections.Generic;
using Solution.Roles.Dto;

namespace Solution.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
