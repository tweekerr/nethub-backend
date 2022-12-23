﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetHub.Data.SqlServer.Context;

#nullable disable

namespace NetHub.Data.SqlServer.Migrations
{
    [DbContext(typeof(SqlServerDbContext))]
    partial class SqlServerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "Permission",
                            ClaimValue = "mt",
                            RoleId = 2L
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "Permission",
                            ClaimValue = "*",
                            UserId = 19L
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<long?>("AppRoleId")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("AppRoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.AppRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ConcurrencyStamp = "901beb85-ed89-402c-bfa0-f85eb9dd4afc",
                            Name = "user",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = 2L,
                            ConcurrencyStamp = "5ab603f6-6e8c-4189-831c-14999b30c293",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.ArticleEntities.Article", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("AuthorId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Banned")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginalArticleLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Published")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.ArticleEntities.ArticleContributor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("LocalizationId")
                        .HasColumnType("bigint");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("LocalizationId");

                    b.HasIndex("UserId");

                    b.ToTable("ArticleContributors");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.ArticleEntities.ArticleLocalization", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("ArticleId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Banned")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Html")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("InternalStatus")
                        .HasColumnType("tinyint");

                    b.Property<string>("LanguageCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)");

                    b.Property<long?>("LastContributorId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Published")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("LanguageCode");

                    b.HasIndex("LastContributorId");

                    b.ToTable("ArticleLocalizations");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.ArticleEntities.ArticleResource", b =>
                {
                    b.Property<Guid>("ResourceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("ArticleId")
                        .HasColumnType("bigint");

                    b.HasKey("ResourceId");

                    b.HasIndex("ArticleId");

                    b.ToTable("ArticleResources");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.ArticleEntities.ArticleTag", b =>
                {
                    b.Property<long>("TagId")
                        .HasColumnType("bigint");

                    b.Property<long>("ArticleId")
                        .HasColumnType("bigint");

                    b.HasKey("TagId", "ArticleId");

                    b.HasIndex("ArticleId");

                    b.ToTable("ArticleTags");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.ArticleEntities.ArticleVote", b =>
                {
                    b.Property<long>("ArticleId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Vote")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArticleId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ArticleVotes");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Language", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Code");

                    b.ToTable("Languages", (string)null);
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.RefreshToken", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Resource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<byte[]>("Bytes")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Filename")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Mimetype")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.ToTable("Resources", (string)null);
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.SavedArticle", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("LocalizationId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("SavedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "LocalizationId");

                    b.HasIndex("LocalizationId");

                    b.ToTable("SavedArticles");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Tag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LockoutEnd")
                        .HasColumnType("datetime2");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<Guid?>("PhotoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProfilePhotoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Registered")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("PhotoId");

                    b.ToTable("UserProfiles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 19L,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9ac70bd5-c9f9-4903-b32d-5c083503630b",
                            Email = "aspadmin@asp.net",
                            EmailConfirmed = true,
                            FirstName = "vlad",
                            LastName = "fit",
                            LockoutEnabled = false,
                            MiddleName = "tarasovich",
                            NormalizedEmail = "ASPADMIN@ASP.NET",
                            NormalizedUserName = "ASPADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEFVWXbnQJ5iUN2R1rPIaQtPcW6nKDbUcvlJSWJy+KvMPOEjdKj+SFqCQI62Xv/F1nQ==",
                            PhoneNumberConfirmed = false,
                            Registered = new DateTime(2022, 12, 15, 15, 32, 36, 624, DateTimeKind.Utc).AddTicks(1698),
                            SecurityStamp = "ad6eec43-1878-4024-8804-edc101a4c66c",
                            TwoFactorEnabled = false,
                            UserName = "aspadmin"
                        });
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Views.ExtendedUserArticle", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("LocalizationId")
                        .HasColumnType("bigint");

                    b.Property<long>("ArticleId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Banned")
                        .HasColumnType("datetime2");

                    b.Property<long>("ContributorId")
                        .HasColumnType("bigint");

                    b.Property<string>("ContributorRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Html")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSaved")
                        .HasColumnType("bit");

                    b.Property<string>("LanguageCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Published")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SavedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.Property<string>("Vote")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LocalizationId");

                    b.ToView("v_ExtendedUserArticle");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.AppRole", null)
                        .WithMany("Users")
                        .HasForeignKey("AppRoleId");

                    b.HasOne("NetHub.Data.SqlServer.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetHub.Data.SqlServer.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.ArticleEntities.Article", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.User", "Author")
                        .WithMany("Articles")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.ArticleEntities.ArticleContributor", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.ArticleEntities.ArticleLocalization", "Localization")
                        .WithMany("Contributors")
                        .HasForeignKey("LocalizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetHub.Data.SqlServer.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Localization");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.ArticleEntities.ArticleLocalization", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.ArticleEntities.Article", "Article")
                        .WithMany("Localizations")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetHub.Data.SqlServer.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetHub.Data.SqlServer.Entities.User", "LastContributor")
                        .WithMany()
                        .HasForeignKey("LastContributorId");

                    b.Navigation("Article");

                    b.Navigation("Language");

                    b.Navigation("LastContributor");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.ArticleEntities.ArticleResource", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.ArticleEntities.Article", "Article")
                        .WithMany("Images")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetHub.Data.SqlServer.Entities.Resource", "Resource")
                        .WithMany()
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.ArticleEntities.ArticleTag", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.ArticleEntities.Article", "Article")
                        .WithMany("Tags")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetHub.Data.SqlServer.Entities.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.ArticleEntities.ArticleVote", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.ArticleEntities.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetHub.Data.SqlServer.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.RefreshToken", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.SavedArticle", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.ArticleEntities.ArticleLocalization", "Localization")
                        .WithMany()
                        .HasForeignKey("LocalizationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NetHub.Data.SqlServer.Entities.User", "User")
                        .WithMany("SavedArticles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Localization");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.User", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.Resource", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId");

                    b.OwnsOne("NetHub.Data.SqlServer.Entities.UsernameChange", "UsernameChanges", b1 =>
                        {
                            b1.Property<long>("UserId")
                                .HasColumnType("bigint");

                            b1.Property<byte>("Count")
                                .HasColumnType("tinyint");

                            b1.Property<DateTime?>("LastTime")
                                .HasColumnType("datetime2");

                            b1.HasKey("UserId");

                            b1.ToTable("UserProfiles");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.Navigation("Photo");

                    b.Navigation("UsernameChanges")
                        .IsRequired();
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.AppRole", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.ArticleEntities.Article", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Localizations");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.ArticleEntities.ArticleLocalization", b =>
                {
                    b.Navigation("Contributors");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.User", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("SavedArticles");
                });
#pragma warning restore 612, 618
        }
    }
}
