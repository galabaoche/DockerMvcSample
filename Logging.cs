﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSample
{
    public class Logging
    {
        public bool IncludeScopes { get; set; }
        public Level LogLevel { get; set; }
    }

    public class Level
    {
        public string Default { get; set; }
        public string System { get; set; }
        public string Microsoft { get; set; }
    }
}
