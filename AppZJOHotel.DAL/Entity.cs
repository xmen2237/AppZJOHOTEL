﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AppZJOHotel.DAL
{
    public abstract class Entity : IId
    {
        public int Id { get; set; }
    }
}
