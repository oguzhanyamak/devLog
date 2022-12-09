﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Kullanici : IdentityUser<string>
    {
        public string? TirId { get; set; }
        public virtual Tir? Tir { get; set; }
    }
}
