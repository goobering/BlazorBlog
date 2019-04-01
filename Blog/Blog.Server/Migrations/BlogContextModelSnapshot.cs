﻿// <auto-generated />
using System;
using Blog.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blog.Server.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blog.Shared.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("Post");

                    b.Property<DateTime>("Posted");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("BlogPosts");

                    b.HasData(
                        new { Id = 1, Author = "Joe Bloggs", Post = "This is a sample blog post.", Posted = new DateTime(2019, 4, 1, 11, 47, 14, 518, DateTimeKind.Local), Title = "Sample Post Title" },
                        new { Id = 2, Author = "Joe Cloggs", Post = "2 This is a sample blog post.", Posted = new DateTime(2019, 3, 31, 11, 47, 14, 520, DateTimeKind.Local), Title = "Sample Post Title 2" },
                        new { Id = 3, Author = "Joe Doggs", Post = "3 This is a sample blog post.", Posted = new DateTime(2019, 3, 30, 11, 47, 14, 520, DateTimeKind.Local), Title = "Sample Post Title 3" },
                        new { Id = 4, Author = "Joe Eloggs", Post = "4 This is a sample blog post.", Posted = new DateTime(2019, 3, 29, 11, 47, 14, 520, DateTimeKind.Local), Title = "Sample Post Title 4" },
                        new { Id = 5, Author = "Joe Floggs", Post = "5 This is a sample blog post.", Posted = new DateTime(2019, 3, 28, 11, 47, 14, 520, DateTimeKind.Local), Title = "Sample Post Title 5" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
