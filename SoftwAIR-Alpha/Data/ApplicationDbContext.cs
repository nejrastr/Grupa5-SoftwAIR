using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SoftwAIR_Alpha.Models;

namespace SoftwAIR_Alpha.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SoftwAIR_Alpha.Models.Avion> Avion { get; set; }
        public DbSet<SoftwAIR_Alpha.Models.Kupovina> Kupovina { get; set; }
        public DbSet<SoftwAIR_Alpha.Models.KupovinaGiftKoda> KupovinaGiftKoda { get; set; }
        public DbSet<SoftwAIR_Alpha.Models.KupovinaKarte> KupovinaKarte { get; set; }
        public DbSet<SoftwAIR_Alpha.Models.Kupac> Kupac { get; set; }
        public DbSet<SoftwAIR_Alpha.Models.UclanjenKupac> UclanjenKupac { get; set; }
        public DbSet<SoftwAIR_Alpha.Models.UclanjenKupac> NeuclanjenKupac { get; set; }
        public DbSet<SoftwAIR_Alpha.Models.GiftKod> GiftKod { get; set; }
        public DbSet<SoftwAIR_Alpha.Models.Karta> Karta { get; set; }
        public DbSet<SoftwAIR_Alpha.Models.Let> Let { get; set; }
        public DbSet<SoftwAIR_Alpha.Models.Lokacija> Lokacija { get; set; }
        public DbSet<SoftwAIR_Alpha.Models.RefundZahtjev> RefundZahtjev { get; set; }
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avion>().ToTable("Avion");

            modelBuilder.Entity<Kupovina>()
                .ToTable("Kupovina")
                .HasDiscriminator<string> ("KupovinaTip")
                .HasValue<KupovinaGiftKoda>("KupovinaGiftKoda")
                .HasValue<KupovinaKarte>("KupovinaKarte");

            modelBuilder.Entity<Kupac>()
                .ToTable("Kupac")
                .HasDiscriminator<string>("KupacTip")
                .HasValue<UclanjenKupac>("UclanjenKupac")
                .HasValue<NeuclanjenKupac>("NeuclanjenKupac");

            modelBuilder.Entity<GiftKod>().ToTable("GiftKod");
            modelBuilder.Entity<Karta>().ToTable("Karta");
            modelBuilder.Entity<Let>().ToTable("Let");
            modelBuilder.Entity<Lokacija>().ToTable("Lokacija");
            modelBuilder.Entity<RefundZahtjev>().ToTable("RefundZahtjev");


            base.OnModelCreating(modelBuilder);
        }
    }
}
