﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Common
{
    public interface ISorting
    {
        string SortBy { get; set; }
        string SortOrder { get; set; }

    }
}
