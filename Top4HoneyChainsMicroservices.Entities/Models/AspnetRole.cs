﻿using System;
using System.Collections.Generic;

namespace Top4HoneyChainsMicroservices.Entities.Models;

public partial class AspnetRole
{
    public Guid ApplicationId { get; set; }

    public Guid RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string LoweredRoleName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual AspnetApplication Application { get; set; } = null!;

    public virtual ICollection<AspnetUser> Users { get; set; } = new List<AspnetUser>();
}
