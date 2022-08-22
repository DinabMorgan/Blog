﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using template_csharp_blog;

#nullable disable

namespace template_csharp_blog.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("template_csharp_blog.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 3,
                            Name = "RomCom"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 5,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Animation"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Kids"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Mystical"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Reality"
                        });
                });

            modelBuilder.Entity("template_csharp_blog.Models.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Platforms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cost = 15.99,
                            Name = "Netflix"
                        },
                        new
                        {
                            Id = 2,
                            Cost = 10.99,
                            Name = "Hulu"
                        },
                        new
                        {
                            Id = 3,
                            Cost = 5.9900000000000002,
                            Name = "AppleTV"
                        },
                        new
                        {
                            Id = 4,
                            Cost = 5.9900000000000002,
                            Name = "Disney+"
                        },
                        new
                        {
                            Id = 5,
                            Cost = 2.9900000000000002,
                            Name = "Noggin"
                        },
                        new
                        {
                            Id = 6,
                            Cost = 8.9900000000000002,
                            Name = "Prime"
                        },
                        new
                        {
                            Id = 7,
                            Cost = 12.99,
                            Name = "HBOMax"
                        },
                        new
                        {
                            Id = 8,
                            Cost = 44.990000000000002,
                            Name = "Cable"
                        },
                        new
                        {
                            Id = 9,
                            Cost = 0.0,
                            Name = "CW"
                        },
                        new
                        {
                            Id = 10,
                            Cost = 5.9900000000000002,
                            Name = "Paramount+"
                        });
                });

            modelBuilder.Entity("template_csharp_blog.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRewatchable")
                        .HasColumnType("bit");

                    b.Property<int>("PlatformId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Thoughts")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PlatformId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Dina",
                            CategoryId = 1,
                            DateTime = new DateTime(2022, 7, 8, 22, 59, 58, 1, DateTimeKind.Local).AddTicks(4007),
                            IsRewatchable = true,
                            PlatformId = 4,
                            Rating = 8,
                            Thoughts = "Gripping",
                            Title = "MoonKnight"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Dina",
                            CategoryId = 2,
                            DateTime = new DateTime(2022, 7, 8, 22, 59, 58, 1, DateTimeKind.Local).AddTicks(4046),
                            IsRewatchable = true,
                            PlatformId = 1,
                            Rating = 10,
                            Thoughts = "Well Wishes and Warmest Regards",
                            Title = "Schitt's Creek"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Dina",
                            CategoryId = 5,
                            DateTime = new DateTime(2022, 7, 8, 22, 59, 58, 1, DateTimeKind.Local).AddTicks(4049),
                            IsRewatchable = true,
                            PlatformId = 10,
                            Rating = 10,
                            Thoughts = "",
                            Title = "Star Trek"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Dina",
                            CategoryId = 7,
                            DateTime = new DateTime(2022, 7, 8, 22, 59, 58, 1, DateTimeKind.Local).AddTicks(4052),
                            IsRewatchable = true,
                            PlatformId = 1,
                            Rating = 10,
                            Thoughts = "By the power of Greyskull",
                            Title = "She-Ra"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Dina",
                            CategoryId = 4,
                            DateTime = new DateTime(2022, 7, 8, 22, 59, 58, 1, DateTimeKind.Local).AddTicks(4053),
                            IsRewatchable = false,
                            PlatformId = 8,
                            Rating = 2,
                            Thoughts = "Very Repeatative ",
                            Title = "NCIS"
                        });
                });

            modelBuilder.Entity("template_csharp_blog.Models.Post", b =>
                {
                    b.HasOne("template_csharp_blog.Models.Category", "Category")
                        .WithMany("posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("template_csharp_blog.Models.Platform", "Platform")
                        .WithMany("Posts")
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("template_csharp_blog.Models.Category", b =>
                {
                    b.Navigation("posts");
                });

            modelBuilder.Entity("template_csharp_blog.Models.Platform", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
