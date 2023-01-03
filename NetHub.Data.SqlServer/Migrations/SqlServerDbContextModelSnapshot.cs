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
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Articles.Article", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

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

                    b.ToTable("Articles", (string)null);
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Articles.ArticleContributor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

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

                    b.ToTable("ArticleContributors", (string)null);
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Articles.ArticleLocalization", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

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

                    b.ToTable("ArticleLocalizations", (string)null);
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Articles.ArticleResource", b =>
                {
                    b.Property<Guid>("ResourceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("ArticleId")
                        .HasColumnType("bigint");

                    b.HasKey("ResourceId");

                    b.HasIndex("ArticleId");

                    b.ToTable("ArticleResources", (string)null);
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Articles.ArticleTag", b =>
                {
                    b.Property<long>("TagId")
                        .HasColumnType("bigint");

                    b.Property<long>("ArticleId")
                        .HasColumnType("bigint");

                    b.HasKey("TagId", "ArticleId");

                    b.HasIndex("ArticleId");

                    b.ToTable("ArticleTags", (string)null);
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Articles.ArticleVote", b =>
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

                    b.ToTable("ArticleVotes", (string)null);
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Identity.AppDevice", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<short>("AttemptCount")
                        .HasColumnType("smallint");

                    b.Property<string>("Browser")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("BrowserVersion")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)");

                    b.Property<DateTime?>("LastAttempt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Platform")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("AppDevices", (string)null);
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Identity.AppRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AppRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ConcurrencyStamp = "1F141CDE-0000-1111-2222-3333444417A1",
                            Name = "user",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = 2L,
                            ConcurrencyStamp = "2F141CDE-0000-1111-2222-33334444ABE2",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Identity.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AppRoleClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 3,
                            ClaimType = "Permissions",
                            ClaimValue = "mt",
                            RoleId = 2L
                        });
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Identity.AppToken", b =>
                {
                    b.Property<string>("Value")
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)");

                    b.Property<long?>("AppUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<long?>("DeviceId")
                        .HasColumnType("bigint");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Value");

                    b.HasIndex("AppUserId");

                    b.HasIndex("DeviceId");

                    b.HasIndex("UserId");

                    b.ToTable("AppTokens", (string)null);
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Identity.AppUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<Guid?>("PhotoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProfilePhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Registered")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<string>("SecurityStamp")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("PhotoId");

                    b.ToTable("AppUsers", (string)null);
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Identity.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserClaims", (string)null);
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Identity.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("ProviderDisplayName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserLogins", (string)null);
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Identity.AppUserRole", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AppUserRoles", (string)null);
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

                    b.ToTable("SavedArticles", (string)null);
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Tag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Tags", (string)null);
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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LocalizationId");

                    b.ToTable((string)null);

                    b.ToView("v_ExtendedUserArticle", (string)null);
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Articles.Article", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.Identity.AppUser", "Author")
                        .WithMany("Articles")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Articles.ArticleContributor", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.Articles.ArticleLocalization", "Localization")
                        .WithMany("Contributors")
                        .HasForeignKey("LocalizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetHub.Data.SqlServer.Entities.Identity.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Localization");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Articles.ArticleLocalization", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.Articles.Article", "Article")
                        .WithMany("Localizations")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetHub.Data.SqlServer.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetHub.Data.SqlServer.Entities.Identity.AppUser", "LastContributor")
                        .WithMany()
                        .HasForeignKey("LastContributorId");

                    b.Navigation("Article");

                    b.Navigation("Language");

                    b.Navigation("LastContributor");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Articles.ArticleResource", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.Articles.Article", "Article")
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

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Articles.ArticleTag", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.Articles.Article", "Article")
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

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Articles.ArticleVote", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.Articles.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetHub.Data.SqlServer.Entities.Identity.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Identity.AppRoleClaim", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.Identity.AppRole", "Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Identity.AppToken", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.Identity.AppUser", null)
                        .WithMany("RefreshTokens")
                        .HasForeignKey("AppUserId");

                    b.HasOne("NetHub.Data.SqlServer.Entities.Identity.AppDevice", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId");

                    b.HasOne("NetHub.Data.SqlServer.Entities.Identity.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Identity.AppUser", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.Resource", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId");

                    b.OwnsOne("NetHub.Data.SqlServer.Entities.Identity.AppUser.UsernameChanges#NetHub.Data.SqlServer.Entities.UsernameChange", "UsernameChanges", b1 =>
                        {
                            b1.Property<long>("AppUserId")
                                .HasColumnType("bigint");

                            b1.Property<byte>("Count")
                                .HasColumnType("tinyint");

                            b1.Property<DateTime?>("LastTime")
                                .HasColumnType("datetime2");

                            b1.HasKey("AppUserId");

                            b1.ToTable("AppUsers", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("AppUserId");
                        });

                    b.Navigation("Photo");

                    b.Navigation("UsernameChanges")
                        .IsRequired();
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Identity.AppUserClaim", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.Identity.AppUser", "User")
                        .WithMany("UserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Identity.AppUserLogin", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Identity.AppUserRole", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.Identity.AppRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetHub.Data.SqlServer.Entities.Identity.AppUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.SavedArticle", b =>
                {
                    b.HasOne("NetHub.Data.SqlServer.Entities.Articles.ArticleLocalization", "Localization")
                        .WithMany()
                        .HasForeignKey("LocalizationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NetHub.Data.SqlServer.Entities.Identity.AppUser", "User")
                        .WithMany("SavedArticles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Localization");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Articles.Article", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Localizations");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Articles.ArticleLocalization", b =>
                {
                    b.Navigation("Contributors");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Identity.AppRole", b =>
                {
                    b.Navigation("RoleClaims");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("NetHub.Data.SqlServer.Entities.Identity.AppUser", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("RefreshTokens");

                    b.Navigation("SavedArticles");

                    b.Navigation("UserClaims");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
