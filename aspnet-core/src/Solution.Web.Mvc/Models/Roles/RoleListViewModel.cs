using System.Collections.Generic;
using Solution.Roles.Dto;

namespace Solution.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
