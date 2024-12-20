﻿using System;
using System.Collections.Generic;

namespace Top4HoneyChainsMicroservices.Entities.Models;

public partial class Apiary
{
    public int ApiaryId { get; set; }

    public Guid? BeekeeperId { get; set; }

    public Guid? ApiaryQrcode { get; set; }

    public string ApiaryTitle { get; set; } = null!;

    public short NumberOfBeehives { get; set; }

    public decimal? LocationLatitude { get; set; }

    public decimal? LocationLongitude { get; set; }

    public int? LocationType { get; set; }

    public int? ProductionPeriodId { get; set; }
}
