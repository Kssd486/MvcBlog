﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcBlog.Models;

namespace MvcBlog.Data
{
    public class MvcBlogContext : DbContext
    {
        public MvcBlogContext(DbContextOptions<MvcBlogContext> options)
           : base(options)
        {
        }

        public DbSet<Post> Post { get; set; }
    }
}