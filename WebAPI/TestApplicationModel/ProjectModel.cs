﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Model.Common;

namespace TestApplicationModel
{
    public class Project : IProject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ClientName { get; set; }
        public int Budget { get; set; }
    }
}
