﻿using System;
using System.Collections.Generic;

namespace Write_Erase.MVVM.Models.Data.Tables;

public partial class Productcategory
{
    public int CategoryId { get; set; }

    public string Category { get; set; } = null!;

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
