﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalBackend.Entities
{
    public class Users
    {
        public Guid id {  get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }

    }
}
