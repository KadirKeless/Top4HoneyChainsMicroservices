﻿using System;
using System.Collections.Generic;

namespace Top4HoneyChainsMicroservices.Entities.Models;

public partial class HoneyDistributionType
{
    public int TypeId { get; set; }

    public string TypeTitle { get; set; } = null!;
}