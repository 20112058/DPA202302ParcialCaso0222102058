﻿using System;
using System.Collections.Generic;

namespace DPA202302ParcialCaso0222102058.Data;

public partial class Country
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public int Code { get; set; }

    public string Currency { get; set; } = null!;
}
