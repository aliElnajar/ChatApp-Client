﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatApp
{
    internal class messdata
    {
        public int id { get; set; }

        public string messagetxt { get; set; }

        public string username { get; set; }
        public string? groupname { get; set; }
    }
}
