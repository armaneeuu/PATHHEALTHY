﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PATHHEALTHY.Models;

namespace PATHHEALTHY.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PATHHEALTHY.Models.Contacto> DataContactos { get; set;}
        public DbSet<PATHHEALTHY.Models.Producto> DataProductos { get; set;}
    }
}
