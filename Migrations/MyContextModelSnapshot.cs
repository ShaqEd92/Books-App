﻿// <auto-generated />
using Lybrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lybrary.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Lybrary.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Genre");

                    b.Property<int>("ReaderID");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("BookID");

                    b.HasIndex("ReaderID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Lybrary.Models.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookID");

                    b.Property<string>("Content");

                    b.Property<int>("ReaderID");

                    b.HasKey("CommentID");

                    b.HasIndex("BookID");

                    b.HasIndex("ReaderID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Lybrary.Models.Favorite", b =>
                {
                    b.Property<int>("FavoriteID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookID");

                    b.Property<int>("ReaderID");

                    b.HasKey("FavoriteID");

                    b.HasIndex("BookID");

                    b.HasIndex("ReaderID");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("Lybrary.Models.Read", b =>
                {
                    b.Property<int>("ReadID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookID");

                    b.Property<int>("ReaderID");

                    b.HasKey("ReadID");

                    b.HasIndex("BookID");

                    b.HasIndex("ReaderID");

                    b.ToTable("Reads");
                });

            modelBuilder.Entity("Lybrary.Models.ReadList", b =>
                {
                    b.Property<int>("ReadListID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookID");

                    b.Property<int>("ReaderID");

                    b.HasKey("ReadListID");

                    b.HasIndex("BookID");

                    b.HasIndex("ReaderID");

                    b.ToTable("ReadLists");
                });

            modelBuilder.Entity("Lybrary.Models.Reader", b =>
                {
                    b.Property<int>("ReaderID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.HasKey("ReaderID");

                    b.ToTable("Readers");
                });

            modelBuilder.Entity("Lybrary.Models.Book", b =>
                {
                    b.HasOne("Lybrary.Models.Reader", "Submitter")
                        .WithMany()
                        .HasForeignKey("ReaderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Lybrary.Models.Comment", b =>
                {
                    b.HasOne("Lybrary.Models.Book", "TheBook")
                        .WithMany("BookComments")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Lybrary.Models.Reader", "TheReader")
                        .WithMany("MyComments")
                        .HasForeignKey("ReaderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Lybrary.Models.Favorite", b =>
                {
                    b.HasOne("Lybrary.Models.Book", "TheBook")
                        .WithMany("Faved")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Lybrary.Models.Reader", "TheReader")
                        .WithMany("MyFaves")
                        .HasForeignKey("ReaderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Lybrary.Models.Read", b =>
                {
                    b.HasOne("Lybrary.Models.Book", "TheBook")
                        .WithMany("ReadBy")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Lybrary.Models.Reader", "TheReader")
                        .WithMany("BooksRead")
                        .HasForeignKey("ReaderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Lybrary.Models.ReadList", b =>
                {
                    b.HasOne("Lybrary.Models.Book", "TheBook")
                        .WithMany("ToRead")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Lybrary.Models.Reader", "TheReader")
                        .WithMany("ReadingList")
                        .HasForeignKey("ReaderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
