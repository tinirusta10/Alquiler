﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    internal class Bdcontext
    {
        public BdContext(DbContextOptions options) : base(options)
        {
        }
    }
}
