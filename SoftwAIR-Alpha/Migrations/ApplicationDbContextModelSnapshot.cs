﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoftwAIR_Alpha.Data;

namespace SoftwAIR_Alpha.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(767)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SoftwAIR_Alpha.Models.Avion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("brojMjestaBiznis")
                        .HasColumnType("int");

                    b.Property<int>("brojMjestaEconomy")
                        .HasColumnType("int");

                    b.Property<int>("brojMjestaPrva")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Avion");
                });

            modelBuilder.Entity("SoftwAIR_Alpha.Models.GiftKod", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("kod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("kupacID")
                        .HasColumnType("int");

                    b.Property<string>("trenutniStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("kupacID");

                    b.ToTable("GiftKod");
                });

            modelBuilder.Entity("SoftwAIR_Alpha.Models.Karta", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("cijena")
                        .HasColumnType("double");

                    b.Property<int>("klasa")
                        .HasColumnType("int");

                    b.Property<int>("polazniLetID")
                        .HasColumnType("int");

                    b.Property<int?>("povratniLetID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("polazniLetID");

                    b.HasIndex("povratniLetID");

                    b.ToTable("Karta");
                });

            modelBuilder.Entity("SoftwAIR_Alpha.Models.Kupac", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("KupacTip")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("broj")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ime")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("loyaltyClan")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("prezime")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Kupac");

                    b.HasDiscriminator<string>("KupacTip").HasValue("Kupac");
                });

            modelBuilder.Entity("SoftwAIR_Alpha.Models.Kupovina", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("KupovinaTip")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("datumKupovine")
                        .HasColumnType("datetime");

                    b.Property<int>("idKupca")
                        .HasColumnType("int");

                    b.Property<string>("statusKupovine")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Kupovina");

                    b.HasDiscriminator<string>("KupovinaTip").HasValue("Kupovina");
                });

            modelBuilder.Entity("SoftwAIR_Alpha.Models.Let", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("avionID")
                        .HasColumnType("int");

                    b.Property<int>("dolazakID")
                        .HasColumnType("int");

                    b.Property<bool>("naPopustuZaLoyalty")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("osnovnaCijena")
                        .HasColumnType("double");

                    b.Property<int>("polazakID")
                        .HasColumnType("int");

                    b.Property<int>("statusLeta")
                        .HasColumnType("int");

                    b.Property<DateTime>("vrijemeDolaska")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("vrijemePolaska")
                        .HasColumnType("datetime");

                    b.HasKey("ID");

                    b.HasIndex("avionID");

                    b.HasIndex("dolazakID");

                    b.HasIndex("polazakID");

                    b.ToTable("Let");
                });

            modelBuilder.Entity("SoftwAIR_Alpha.Models.Lokacija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("aerodrom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("grad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Lokacija");
                });

            modelBuilder.Entity("SoftwAIR_Alpha.Models.RefundZahtjev", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("kupacID")
                        .HasColumnType("int");

                    b.Property<int>("kupovinaID")
                        .HasColumnType("int");

                    b.Property<string>("statusZahtjeva")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("vrijemePodnosenja")
                        .HasColumnType("datetime");

                    b.HasKey("ID");

                    b.HasIndex("kupacID");

                    b.HasIndex("kupovinaID");

                    b.ToTable("RefundZahtjev");
                });

            modelBuilder.Entity("SoftwAIR_Alpha.Models.NeuclanjenKupac", b =>
                {
                    b.HasBaseType("SoftwAIR_Alpha.Models.Kupac");

                    b.HasDiscriminator().HasValue("NeuclanjenKupac");
                });

            modelBuilder.Entity("SoftwAIR_Alpha.Models.UclanjenKupac", b =>
                {
                    b.HasBaseType("SoftwAIR_Alpha.Models.Kupac");

                    b.HasDiscriminator().HasValue("UclanjenKupac");
                });

            modelBuilder.Entity("SoftwAIR_Alpha.Models.KupovinaGiftKoda", b =>
                {
                    b.HasBaseType("SoftwAIR_Alpha.Models.Kupovina");

                    b.Property<int>("giftkodid")
                        .HasColumnType("int");

                    b.HasIndex("giftkodid");

                    b.HasDiscriminator().HasValue("KupovinaGiftKoda");
                });

            modelBuilder.Entity("SoftwAIR_Alpha.Models.KupovinaKarte", b =>
                {
                    b.HasBaseType("SoftwAIR_Alpha.Models.Kupovina");

                    b.Property<int>("brojKarti")
                        .HasColumnType("int");

                    b.Property<DateTime>("datumPolaska")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("datumPovratka")
                        .HasColumnType("datetime");

                    b.Property<int>("lokacijaOdredistaID")
                        .HasColumnType("int");

                    b.Property<int>("lokacijaPolaskaID")
                        .HasColumnType("int");

                    b.HasIndex("lokacijaOdredistaID");

                    b.HasIndex("lokacijaPolaskaID");

                    b.HasDiscriminator().HasValue("KupovinaKarte");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SoftwAIR_Alpha.Models.GiftKod", b =>
                {
                    b.HasOne("SoftwAIR_Alpha.Models.Kupac", "kupac")
                        .WithMany()
                        .HasForeignKey("kupacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SoftwAIR_Alpha.Models.Karta", b =>
                {
                    b.HasOne("SoftwAIR_Alpha.Models.Let", "polazniLet")
                        .WithMany()
                        .HasForeignKey("polazniLetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SoftwAIR_Alpha.Models.Let", "povratniLet")
                        .WithMany()
                        .HasForeignKey("povratniLetID");
                });

            modelBuilder.Entity("SoftwAIR_Alpha.Models.Let", b =>
                {
                    b.HasOne("SoftwAIR_Alpha.Models.Avion", "avion")
                        .WithMany()
                        .HasForeignKey("avionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SoftwAIR_Alpha.Models.Lokacija", "dolazak")
                        .WithMany()
                        .HasForeignKey("dolazakID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SoftwAIR_Alpha.Models.Lokacija", "polazak")
                        .WithMany()
                        .HasForeignKey("polazakID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SoftwAIR_Alpha.Models.RefundZahtjev", b =>
                {
                    b.HasOne("SoftwAIR_Alpha.Models.Kupac", "kupac")
                        .WithMany()
                        .HasForeignKey("kupacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SoftwAIR_Alpha.Models.Kupovina", "kupovina")
                        .WithMany()
                        .HasForeignKey("kupovinaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SoftwAIR_Alpha.Models.KupovinaGiftKoda", b =>
                {
                    b.HasOne("SoftwAIR_Alpha.Models.GiftKod", "giftkod")
                        .WithMany()
                        .HasForeignKey("giftkodid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SoftwAIR_Alpha.Models.KupovinaKarte", b =>
                {
                    b.HasOne("SoftwAIR_Alpha.Models.Lokacija", "lokacijaOdredista")
                        .WithMany()
                        .HasForeignKey("lokacijaOdredistaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SoftwAIR_Alpha.Models.Lokacija", "lokacijaPolaska")
                        .WithMany()
                        .HasForeignKey("lokacijaPolaskaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
