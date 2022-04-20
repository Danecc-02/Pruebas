﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroEventos.Data;

namespace RegistroEventos.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220420024010_update3")]
    partial class update3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RegistroEventos.Models.Capitulo", b =>
                {
                    b.Property<int>("id_capitulo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_tipo_capitulo")
                        .HasColumnType("int");

                    b.Property<string>("lugar_capitulo")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("nombre_capitulo")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("id_capitulo");

                    b.HasIndex("id_tipo_capitulo");

                    b.ToTable("capitulos");
                });

            modelBuilder.Entity("RegistroEventos.Models.Comprobante", b =>
                {
                    b.Property<int>("id_comprobante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("comprobante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_tipo_pago")
                        .HasColumnType("int");

                    b.HasKey("id_comprobante");

                    b.HasIndex("id_tipo_pago");

                    b.ToTable("comprobantes");
                });

            modelBuilder.Entity("RegistroEventos.Models.Estadia", b =>
                {
                    b.Property<int>("id_estadia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("reservación_estadia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_estadia");

                    b.ToTable("estadias");
                });

            modelBuilder.Entity("RegistroEventos.Models.Evento", b =>
                {
                    b.Property<int>("id_evento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("fecha_evento")
                        .HasColumnType("datetime2");

                    b.Property<int>("id_tipo_evento")
                        .HasColumnType("int");

                    b.Property<string>("lugar_evento")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("nombre_evento")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("observaciones")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("id_evento");

                    b.HasIndex("id_tipo_evento");

                    b.ToTable("eventos");
                });

            modelBuilder.Entity("RegistroEventos.Models.Evento_participante", b =>
                {
                    b.Property<int>("id_evento_participante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_comprobante")
                        .HasColumnType("int");

                    b.Property<int>("id_estadia")
                        .HasColumnType("int");

                    b.Property<int>("id_evento")
                        .HasColumnType("int");

                    b.Property<int>("id_participante")
                        .HasColumnType("int");

                    b.HasKey("id_evento_participante");

                    b.HasIndex("id_comprobante");

                    b.HasIndex("id_estadia");

                    b.HasIndex("id_evento");

                    b.HasIndex("id_participante");

                    b.ToTable("evento_Participantes");
                });

            modelBuilder.Entity("RegistroEventos.Models.Participante", b =>
                {
                    b.Property<int>("id_participante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido_participante")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("dni_participante")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("id_capitulo")
                        .HasColumnType("int");

                    b.Property<string>("nombre_participante")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("telefono")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("id_participante");

                    b.HasIndex("id_capitulo");

                    b.ToTable("participantes");
                });

            modelBuilder.Entity("RegistroEventos.Models.Tipo_capitulo", b =>
                {
                    b.Property<int>("id_tipo_capitulo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre_tipo_capitulo")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("id_tipo_capitulo");

                    b.ToTable("tipo_Capitulos");
                });

            modelBuilder.Entity("RegistroEventos.Models.Tipo_evento", b =>
                {
                    b.Property<int>("id_tipo_evento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre_tipo_evento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_tipo_evento");

                    b.ToTable("tipo_Eventos");
                });

            modelBuilder.Entity("RegistroEventos.Models.Tipo_pago", b =>
                {
                    b.Property<int>("id_tipo_pago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tipo_pago")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_tipo_pago");

                    b.ToTable("tipo_Pagos");
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

            modelBuilder.Entity("RegistroEventos.Models.Capitulo", b =>
                {
                    b.HasOne("RegistroEventos.Models.Tipo_capitulo", "Tipo_capitulo")
                        .WithMany("Capitulos")
                        .HasForeignKey("id_tipo_capitulo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipo_capitulo");
                });

            modelBuilder.Entity("RegistroEventos.Models.Comprobante", b =>
                {
                    b.HasOne("RegistroEventos.Models.Tipo_pago", "Tipo_pago")
                        .WithMany("Comprobantes")
                        .HasForeignKey("id_tipo_pago")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipo_pago");
                });

            modelBuilder.Entity("RegistroEventos.Models.Evento", b =>
                {
                    b.HasOne("RegistroEventos.Models.Tipo_evento", "Tipo_Evento")
                        .WithMany("Eventos")
                        .HasForeignKey("id_tipo_evento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipo_Evento");
                });

            modelBuilder.Entity("RegistroEventos.Models.Evento_participante", b =>
                {
                    b.HasOne("RegistroEventos.Models.Comprobante", "Comprobante")
                        .WithMany()
                        .HasForeignKey("id_comprobante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegistroEventos.Models.Estadia", "Estadia")
                        .WithMany("Evento_Participantes")
                        .HasForeignKey("id_estadia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegistroEventos.Models.Evento", "Evento")
                        .WithMany("Evento_Participantes")
                        .HasForeignKey("id_evento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegistroEventos.Models.Participante", "Participantes")
                        .WithMany("Evento_Participantes")
                        .HasForeignKey("id_participante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comprobante");

                    b.Navigation("Estadia");

                    b.Navigation("Evento");

                    b.Navigation("Participantes");
                });

            modelBuilder.Entity("RegistroEventos.Models.Participante", b =>
                {
                    b.HasOne("RegistroEventos.Models.Capitulo", "Capitulo")
                        .WithMany("Participantes")
                        .HasForeignKey("id_capitulo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Capitulo");
                });

            modelBuilder.Entity("RegistroEventos.Models.Capitulo", b =>
                {
                    b.Navigation("Participantes");
                });

            modelBuilder.Entity("RegistroEventos.Models.Estadia", b =>
                {
                    b.Navigation("Evento_Participantes");
                });

            modelBuilder.Entity("RegistroEventos.Models.Evento", b =>
                {
                    b.Navigation("Evento_Participantes");
                });

            modelBuilder.Entity("RegistroEventos.Models.Participante", b =>
                {
                    b.Navigation("Evento_Participantes");
                });

            modelBuilder.Entity("RegistroEventos.Models.Tipo_capitulo", b =>
                {
                    b.Navigation("Capitulos");
                });

            modelBuilder.Entity("RegistroEventos.Models.Tipo_evento", b =>
                {
                    b.Navigation("Eventos");
                });

            modelBuilder.Entity("RegistroEventos.Models.Tipo_pago", b =>
                {
                    b.Navigation("Comprobantes");
                });
#pragma warning restore 612, 618
        }
    }
}
