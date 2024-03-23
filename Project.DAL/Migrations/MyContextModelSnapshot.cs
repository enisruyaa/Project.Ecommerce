﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.DAL.ContextClasses;

#nullable disable

namespace Project.DAL.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "a5df7d43-2095-48a3-95c9-e22a0df81dcd",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Project.ENTITIES.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

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

                    b.Property<int>("Status")
                        .HasColumnType("int");

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

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d4084759-d0ac-4fae-b822-8c7274f81803",
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9827),
                            Email = "enisruya@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ENISRUYA@GMAIL.COM",
                            NormalizedUserName = "ENS123",
                            PasswordHash = "AQAAAAIAAYagAAAAEP5aSROwdCbQSmEHWu7YkbkOCy2SUEUh3gP9H1PUG+LJUPCwUm0mefWyOVQfsfhzaA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7efee34c-d7aa-45c7-a0d9-799ee7ad9c8f",
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "ens123"
                        });
                });

            modelBuilder.Entity("Project.ENTITIES.Models.AppUserProfile", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryName = "Home",
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8108),
                            Description = "Alias adipisci qui sıfat ea sit consequatur yazın sarmal esse.",
                            Status = 1
                        },
                        new
                        {
                            ID = 2,
                            CategoryName = "Home",
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8375),
                            Description = "Düşünüyor quis qui alias consequuntur alias magni balıkhaneye tv ki.",
                            Status = 1
                        },
                        new
                        {
                            ID = 3,
                            CategoryName = "Tools",
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8451),
                            Description = "Dolores autem sequi de kapının nesciunt şafak amet aut umut.",
                            Status = 1
                        },
                        new
                        {
                            ID = 4,
                            CategoryName = "Home",
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8500),
                            Description = "Modi qui gördüm nesciunt explicabo sokaklarda dışarı voluptatum voluptatem sit.",
                            Status = 1
                        },
                        new
                        {
                            ID = 5,
                            CategoryName = "Sports",
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8548),
                            Description = "Autem de quia et sayfası esse adresini sarmal telefonu modi.",
                            Status = 1
                        },
                        new
                        {
                            ID = 6,
                            CategoryName = "Kids",
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8594),
                            Description = "Bilgiyasayarı molestiae praesentium veniam qui domates vitae mi değirmeni ve.",
                            Status = 1
                        },
                        new
                        {
                            ID = 7,
                            CategoryName = "Books",
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8666),
                            Description = "Mıknatıslı non gazete ama dergi dolayı lambadaki laudantium minima enim.",
                            Status = 1
                        },
                        new
                        {
                            ID = 8,
                            CategoryName = "Kids",
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8715),
                            Description = "Çarpan ad iusto inventore vitae kalemi amet için consequuntur inventore.",
                            Status = 1
                        },
                        new
                        {
                            ID = 9,
                            CategoryName = "Clothing",
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8761),
                            Description = "Mutlu nostrum ab sed öyle sed şafak iure non eum.",
                            Status = 1
                        },
                        new
                        {
                            ID = 10,
                            CategoryName = "Clothing",
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8805),
                            Description = "Reprehenderit layıkıyla illo sunt suscipit değirmeni enim quia veritatis doloremque.",
                            Status = 1
                        });
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("AppUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PriceOfOrder")
                        .HasColumnType("money");

                    b.Property<int?>("ShipperID")
                        .HasColumnType("int");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AppUserID");

                    b.HasIndex("ShipperID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("money");

                    b.HasKey("OrderID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("money");

                    b.Property<int>("UnitsInStock")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = 1,
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8912),
                            ImagePath = "http://lorempixel.com/640/480/nightlife",
                            ProductName = "Licensed Wooden Soap",
                            Status = 1,
                            UnitPrice = 885.81m,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 2,
                            CategoryID = 2,
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9113),
                            ImagePath = "http://lorempixel.com/640/480/nightlife",
                            ProductName = "Handcrafted Frozen Gloves",
                            Status = 1,
                            UnitPrice = 947.03m,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 3,
                            CategoryID = 3,
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9174),
                            ImagePath = "http://lorempixel.com/640/480/nightlife",
                            ProductName = "Refined Rubber Keyboard",
                            Status = 1,
                            UnitPrice = 340.84m,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 4,
                            CategoryID = 4,
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9227),
                            ImagePath = "http://lorempixel.com/640/480/nightlife",
                            ProductName = "Ergonomic Granite Bacon",
                            Status = 1,
                            UnitPrice = 837.30m,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 5,
                            CategoryID = 5,
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9300),
                            ImagePath = "http://lorempixel.com/640/480/nightlife",
                            ProductName = "Fantastic Rubber Fish",
                            Status = 1,
                            UnitPrice = 690.13m,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 6,
                            CategoryID = 6,
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9355),
                            ImagePath = "http://lorempixel.com/640/480/nightlife",
                            ProductName = "Ergonomic Steel Computer",
                            Status = 1,
                            UnitPrice = 478.96m,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 7,
                            CategoryID = 7,
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9405),
                            ImagePath = "http://lorempixel.com/640/480/nightlife",
                            ProductName = "Handcrafted Soft Pizza",
                            Status = 1,
                            UnitPrice = 147.38m,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 8,
                            CategoryID = 8,
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9454),
                            ImagePath = "http://lorempixel.com/640/480/nightlife",
                            ProductName = "Incredible Metal Mouse",
                            Status = 1,
                            UnitPrice = 962.54m,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 9,
                            CategoryID = 9,
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9504),
                            ImagePath = "http://lorempixel.com/640/480/nightlife",
                            ProductName = "Unbranded Plastic Chips",
                            Status = 1,
                            UnitPrice = 928.76m,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 10,
                            CategoryID = 10,
                            CreatedDate = new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9579),
                            ImagePath = "http://lorempixel.com/640/480/nightlife",
                            ProductName = "Refined Concrete Chair",
                            Status = 1,
                            UnitPrice = 242.36m,
                            UnitsInStock = 100
                        });
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Shipper", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Project.ENTITIES.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Project.ENTITIES.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.ENTITIES.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Project.ENTITIES.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project.ENTITIES.Models.AppUserProfile", b =>
                {
                    b.HasOne("Project.ENTITIES.Models.AppUser", "AppUser")
                        .WithOne("Profile")
                        .HasForeignKey("Project.ENTITIES.Models.AppUserProfile", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Order", b =>
                {
                    b.HasOne("Project.ENTITIES.Models.AppUser", "AppUser")
                        .WithMany("Orders")
                        .HasForeignKey("AppUserID");

                    b.HasOne("Project.ENTITIES.Models.Shipper", "Shipper")
                        .WithMany("Orders")
                        .HasForeignKey("ShipperID");

                    b.Navigation("AppUser");

                    b.Navigation("Shipper");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.OrderDetail", b =>
                {
                    b.HasOne("Project.ENTITIES.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.ENTITIES.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Product", b =>
                {
                    b.HasOne("Project.ENTITIES.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.AppUser", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Profile")
                        .IsRequired();
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Shipper", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
