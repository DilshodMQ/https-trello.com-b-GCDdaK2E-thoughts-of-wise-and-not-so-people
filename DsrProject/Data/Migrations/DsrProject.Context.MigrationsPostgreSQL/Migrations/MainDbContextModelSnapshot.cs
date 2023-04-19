﻿// <auto-generated />
using System;
using DsrProject.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DsrProject.Context.MigrationsPostgreSQL.Migrations
{
    [DbContext(typeof(MainDbContext))]
    partial class MainDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DsrProject.Context.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<Guid>("Uid")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("Uid")
                        .IsUnique();

                    b.ToTable("authors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ali",
                            Uid = new Guid("cbacb2d5-e62f-45eb-9184-cafae7774404")
                        });
                });

            modelBuilder.Entity("DsrProject.Context.Entities.AuthorDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId")
                        .IsUnique();

                    b.ToTable("authordetails", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Country = "UZ",
                            Family = "Aliyev"
                        });
                });

            modelBuilder.Entity("DsrProject.Context.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<Guid>("Uid")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("Uid")
                        .IsUnique();

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("DsrProject.Context.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RespondentId")
                        .HasColumnType("integer");

                    b.Property<int>("ThoughtId")
                        .HasColumnType("integer");

                    b.Property<Guid>("Uid")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RespondentId");

                    b.HasIndex("ThoughtId");

                    b.HasIndex("Uid")
                        .IsUnique();

                    b.ToTable("comments", (string)null);
                });

            modelBuilder.Entity("DsrProject.Context.Entities.Respondent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("Uid")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("Uid")
                        .IsUnique();

                    b.ToTable("respondents", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Tom@Talking.ru",
                            Name = "Tom",
                            Uid = new Guid("ab32a178-035e-4a04-b875-703d678967fd")
                        });
                });

            modelBuilder.Entity("DsrProject.Context.Entities.Thought", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<Guid>("Uid")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("Uid")
                        .IsUnique();

                    b.ToTable("thoughts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Description = "Hello world",
                            Title = "Best",
                            Uid = new Guid("4216884b-efa7-4c14-888f-f95d5a863a66")
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Description = "Hello programmer",
                            Title = "Worst",
                            Uid = new Guid("8afb95cc-1f4b-4ce7-9f01-e3ab8876f4ba")
                        });
                });

            modelBuilder.Entity("DsrProject.Context.Entities.ThoughtCategory", b =>
                {
                    b.Property<int>("ThoughtId")
                        .HasColumnType("integer");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<Guid>("Uid")
                        .HasColumnType("uuid");

                    b.HasKey("ThoughtId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("thoughts_categories", (string)null);
                });

            modelBuilder.Entity("DsrProject.Context.Entities.ThoughtRespondent", b =>
                {
                    b.Property<int>("ThoughtId")
                        .HasColumnType("integer");

                    b.Property<int>("RespondentId")
                        .HasColumnType("integer");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<Guid>("Uid")
                        .HasColumnType("uuid");

                    b.HasKey("ThoughtId", "RespondentId");

                    b.HasIndex("RespondentId");

                    b.ToTable("thoughts_respondents", (string)null);
                });

            modelBuilder.Entity("DsrProject.Context.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("DsrProject.Context.Entities.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DsrProject.Context.Entities.AuthorDetail", b =>
                {
                    b.HasOne("DsrProject.Context.Entities.Author", "Author")
                        .WithOne("Detail")
                        .HasForeignKey("DsrProject.Context.Entities.AuthorDetail", "AuthorId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("DsrProject.Context.Entities.Comment", b =>
                {
                    b.HasOne("DsrProject.Context.Entities.Respondent", "Respondent")
                        .WithMany("Comments")
                        .HasForeignKey("RespondentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DsrProject.Context.Entities.Thought", "Thought")
                        .WithMany("Comments")
                        .HasForeignKey("ThoughtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Respondent");

                    b.Navigation("Thought");
                });

            modelBuilder.Entity("DsrProject.Context.Entities.Thought", b =>
                {
                    b.HasOne("DsrProject.Context.Entities.Author", "Author")
                        .WithMany("Thoughts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("DsrProject.Context.Entities.ThoughtCategory", b =>
                {
                    b.HasOne("DsrProject.Context.Entities.Category", "Category")
                        .WithMany("ThoughtCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DsrProject.Context.Entities.Thought", "Thought")
                        .WithMany("ThoughtCategories")
                        .HasForeignKey("ThoughtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Thought");
                });

            modelBuilder.Entity("DsrProject.Context.Entities.ThoughtRespondent", b =>
                {
                    b.HasOne("DsrProject.Context.Entities.Respondent", "Respondent")
                        .WithMany("ThoughtRespondents")
                        .HasForeignKey("RespondentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DsrProject.Context.Entities.Thought", "Thought")
                        .WithMany("ThoughtRespondents")
                        .HasForeignKey("ThoughtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Respondent");

                    b.Navigation("Thought");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("DsrProject.Context.Entities.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("DsrProject.Context.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("DsrProject.Context.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("DsrProject.Context.Entities.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DsrProject.Context.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("DsrProject.Context.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DsrProject.Context.Entities.Author", b =>
                {
                    b.Navigation("Detail");

                    b.Navigation("Thoughts");
                });

            modelBuilder.Entity("DsrProject.Context.Entities.Category", b =>
                {
                    b.Navigation("ThoughtCategories");
                });

            modelBuilder.Entity("DsrProject.Context.Entities.Respondent", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("ThoughtRespondents");
                });

            modelBuilder.Entity("DsrProject.Context.Entities.Thought", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("ThoughtCategories");

                    b.Navigation("ThoughtRespondents");
                });
#pragma warning restore 612, 618
        }
    }
}
