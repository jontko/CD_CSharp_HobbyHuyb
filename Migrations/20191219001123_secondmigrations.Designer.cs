﻿// <auto-generated />
using System;
using HobbyHub.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HobbyHub.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20191219001123_secondmigrations")]
    partial class secondmigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("HobbyHub.Models.Enthusiast", b =>
                {
                    b.Property<int>("EnthusiastId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("HobbyId");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("EnthusiastId");

                    b.HasIndex("HobbyId");

                    b.HasIndex("UserId");

                    b.ToTable("Enthusiasts");
                });

            modelBuilder.Entity("HobbyHub.Models.Hobby", b =>
                {
                    b.Property<int>("HobbyId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int?>("HobbyOwnerUserId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("HobbyId");

                    b.HasIndex("HobbyOwnerUserId");

                    b.ToTable("Hobbys");
                });

            modelBuilder.Entity("HobbyHub.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HobbyHub.Models.Enthusiast", b =>
                {
                    b.HasOne("HobbyHub.Models.Hobby", "Hobby")
                        .WithMany("HobbyLiker")
                        .HasForeignKey("HobbyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HobbyHub.Models.User", "User")
                        .WithMany("UserHobbyFans")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HobbyHub.Models.Hobby", b =>
                {
                    b.HasOne("HobbyHub.Models.User", "HobbyOwner")
                        .WithMany("UserHobby")
                        .HasForeignKey("HobbyOwnerUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
