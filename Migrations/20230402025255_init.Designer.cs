﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using iTec_project.DataBase;

#nullable disable

namespace iTec_project.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230402025255_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.2.23128.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("iTec_project.Features.Profiles.Models.ProfileModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int[]>("BackendFramework")
                        .HasColumnType("integer[]");

                    b.Property<int[]>("BackendFrameworkTools")
                        .HasColumnType("integer[]");

                    b.Property<int[]>("CommunicationSkillsRating")
                        .HasColumnType("integer[]");

                    b.Property<int?>("ComunicationStyle")
                        .HasColumnType("integer");

                    b.Property<int?>("ConflictsHandle")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateStarted")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("DevPost")
                        .HasColumnType("integer");

                    b.Property<int[]>("FrameworkExperience")
                        .HasColumnType("integer[]");

                    b.Property<int[]>("FrontendFramework")
                        .HasColumnType("integer[]");

                    b.Property<int[]>("FrontendFrameworkTools")
                        .HasColumnType("integer[]");

                    b.Property<int[]>("IndustriesWorkExperience")
                        .HasColumnType("integer[]");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OtherBackendFrameworkOption")
                        .HasColumnType("text");

                    b.Property<string>("OtherComunicationStyle")
                        .HasColumnType("text");

                    b.Property<string>("OtherConflictsHandle")
                        .HasColumnType("text");

                    b.Property<string>("OtherFrontendFrameworkOption")
                        .HasColumnType("text");

                    b.Property<string>("OtherOption")
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .HasColumnType("text");

                    b.Property<int?>("ProgramingLanguages")
                        .HasColumnType("integer");

                    b.Property<int[]>("TeamWorkAbilityRate")
                        .HasColumnType("integer[]");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<int[]>("WorkExperience")
                        .HasColumnType("integer[]");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("iTec_project.Features.Roles.Models.RoleModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("iTec_project.Features.Users.Models.UserModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Hashed")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("QuickInfo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("iTec_project.Features.Profiles.Models.ProfileModel", b =>
                {
                    b.HasOne("iTec_project.Features.Users.Models.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("iTec_project.Features.Users.Models.UserModel", b =>
                {
                    b.HasOne("iTec_project.Features.Roles.Models.RoleModel", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}