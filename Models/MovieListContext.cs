﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_3.Models
{
    public class MovieListContext : DbContext
    {
        public MovieListContext (DbContextOptions<MovieListContext> options) : base(options)
        {

        }

        public DbSet<Class> Classes { get; set; }
    }
}
