﻿using Dayana.Shared.Persistence.Models.Identity.Base.Roles;

namespace Dayana.Shared.Persistence.Models.Identity.Base.Users;

public class UserRoleModel
{
    public int RoleId { get; set; }
    public int UserId { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public UserModel User { get; set; }
    public RoleModel Role { get; set; }
}