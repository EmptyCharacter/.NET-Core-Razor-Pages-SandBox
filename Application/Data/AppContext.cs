﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Data
{
    public class AppContext : DbContext
    {

        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {

        }


       
    }
}
