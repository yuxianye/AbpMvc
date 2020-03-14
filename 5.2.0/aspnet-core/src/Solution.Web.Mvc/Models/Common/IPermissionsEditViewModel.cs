using System.Collections.Generic;
using Solution.Roles.Dto;

namespace Solution.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}