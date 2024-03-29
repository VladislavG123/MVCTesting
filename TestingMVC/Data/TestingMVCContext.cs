﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestingMVC.Models;

namespace TestingMVC.Models
{
    public class TestingMVCContext : DbContext
    {
        public TestingMVCContext (DbContextOptions<TestingMVCContext> options)
            : base(options)
        {
        }

        public DbSet<TestingMVC.Models.Movie> Movie { get; set; }

        public DbSet<TestingMVC.Models.Car> Car { get; set; }
    }
}
