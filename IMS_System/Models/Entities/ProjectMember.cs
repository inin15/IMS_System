﻿using System;
using System.Collections.Generic;

namespace IMS_System.Models.Entities;

public partial class ProjectMember
{
    public int Id { get; set; }

    public int? ProjectId { get; set; }

    public int? UserId { get; set; }

    public int? IsLeader { get; set; }

    public virtual Project? Project { get; set; }

    public virtual User? User { get; set; }
}
