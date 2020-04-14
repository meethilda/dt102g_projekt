using System;
using System.Collections.Generic;
using System.Text;
using dt102g_projekt.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dt102g_projekt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Reservation> Reservations;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<dt102g_projekt.Models.Reservation> Reservation { get; set; }
    }
}
