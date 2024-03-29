﻿// <auto-generated />
using System;
using BookWise.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookWise.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240210132330_ChangeReviewTextLenght")]
    partial class ChangeReviewTextLenght
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BookWise.Infrastructure.Data.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1981, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Rebecca",
                            ImageUrl = "https://api.entangledpublishing.com/storage/authors/author_16672544738496.jpg",
                            LastName = "Yarros"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1947, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Stephen",
                            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjA2ODIxNDM4Nl5BMl5BanBnXkFtZTYwMjkzMzU1._V1_FMjpg_UX1000_.jpg",
                            LastName = "King"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1993, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Emily",
                            ImageUrl = "https://images4.penguinrandomhouse.com/author/306512",
                            LastName = "Henry"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1950, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Sara",
                            ImageUrl = "https://m.media-amazon.com/images/S/amzn-author-media-prod/m4mrdgmu85gfv47i68pc875a7p._SX450_CR0%2C0%2C450%2C450_.jpg",
                            LastName = "Forden"
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(1775, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jane",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cc/CassandraAusten-JaneAusten%28c.1810%29_hires.jpg/800px-CassandraAusten-JaneAusten%28c.1810%29_hires.jpg",
                            LastName = "Austen"
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(1977, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Owen",
                            ImageUrl = "https://owen-king.com/wp-content/uploads/2022/07/owen-king-author2.jpg",
                            LastName = "King"
                        });
                });

            modelBuilder.Entity("BookWise.Infrastructure.Data.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Twenty-year-old Violet Sorrengail was supposed to enter the Scribe Quadrant, living a quiet life among books and history. Now, the commanding general also known as her tough as talons mother has ordered Violet to join the hundreds of candidates striving to become the elite of Navarre: dragon riders.But when you’re smaller than everyone else and your body is brittle, death is only a heartbeat away...because dragons don’t bond to “fragile” humans. They incinerate them.With fewer dragons willing to bond than cadets, most would kill Violet to better their own chances of success. The rest would kill her just for being her mother’s daughter like Xaden Riorson, the most powerful and ruthless wingleader in the Riders Quadrant.She’ll need every edge her wits can give her just to see the next sunrise.Yet, with every day that passes, the war outside grows more deadly, the kingdom's protective wards are failing, and the death toll continues to rise. Even worse, Violet begins to suspect leadership is hiding a terrible secret.Friends, enemies, lovers. Everyone at Basgiath War College has an agenda because once you enter, there are only two ways out: graduate or die.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/dd/Fourth_Wing_Cover_Art.jpeg",
                            NumberOfPages = 498,
                            PublicationDate = new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Red Tower Books",
                            Title = "Fourth Wing"
                        },
                        new
                        {
                            Id = 2,
                            Description = "In the middle of the night, in a house on a quiet street in suburban Minneapolis, intruders silently murder Luke Ellis’s parents and load him into a black SUV. The operation takes less than two minutes. Luke will wake up at The Institute, in a room that looks just like his own, except there’s no window. And outside his door are other doors, behind which are other kids with special talents telekinesis and telepathy who got to this place the same way Luke did: Kalisha, Nick, George, Iris, and ten-year-old Avery Dixon. They are all in Front Half. Others, Luke learns, graduated to Back Half, “like the roach motel,” Kalisha says. “You check in, but you don’t check out.” In this most sinister of institutions, the director, Mrs. Sigsby, and her staff are ruthlessly dedicated to extracting from these children the force of their extranormal gifts. There are no scruples here. If you go along, you get tokens for the vending machines. If you don’t, punishment is brutal. As each new victim disappears to Back Half, Luke becomes more and more desperate to get out and get help. But no one has ever escaped from the Institute.As psychically terrifying as Firestarter, and with the spectacular kid power of It, The Institute is Stephen King's gut-wrenchingly dramatic story of good versus evil in a world where the good guys don't always win.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/00/The_Institute_%28King_novel%29.png",
                            NumberOfPages = 576,
                            PublicationDate = new DateTime(2019, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Scribner",
                            Title = "The Institute"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Poppy and Alex. Alex and Poppy. They have nothing in common. She’s a wild child; he wears khakis. She has insatiable wanderlust; he prefers to stay home with a book. And somehow, ever since a fateful car share home from college many years ago, they are the very best of friends. For most of the year they live far apart she’s in New York City, and he’s in their small hometown but every summer, for a decade, they have taken one glorious week of vacation together. Until two years ago, when they ruined everything. They haven’t spoken since. Poppy has everything she should want, but she’s stuck in a rut. When someone asks when she was last truly happy, she knows, without a doubt, it was on that ill-fated, final trip with Alex. And so, she decides to convince her best friend to take one more vacation together lay everything on the table, make it all right. Miraculously, he agrees. Now she has a week to fix everything. If only she can get around the one big truth that has always stood quietly in the middle of their seemingly perfect relationship. What could possibly go wrong?",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/20/People_We_Meet_on_Vacation.jpg",
                            NumberOfPages = 364,
                            PublicationDate = new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Berkley Books",
                            Title = "People We Meet on Vacation"
                        },
                        new
                        {
                            Id = 4,
                            Description = " On the morning of March 27, 1995, four quick shots cracked through Milan’s elegant streets. Maurizio Gucci, heir to the fabulous fashion dynasty, had been ambushed, slain on the steps to his office by an unknown gunman. Two years later, Milan’s chief of police entered the sumptuous palazzo of Maurizio’s ex-wife, Patrizia Reggiani nicknamed “the Black Widow” by the press and arrested her for the murder. Did Patrizia kill her ex-husband because his spending was wildly out of control? Did she do it because he was preparing to marry his mistress? Or is it possible Patrizia didn’t do it at all? The Gucci story is one of glitz, glamour, and intrigue a chronicle of the rise, near fall, and subsequent resurgence of a fashion dynasty. Beautifully written, impeccably researched, and widely acclaimed, The House of Gucci is a page-turning account of high fashion, high finance, and heartrending personal tragedy.",
                            ImageUrl = "https://prodimage.images-bn.com/pimages/9788811004349_p0_v1_s1200x630.jpg",
                            NumberOfPages = 288,
                            PublicationDate = new DateTime(2000, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Mariner Books",
                            Title = "The House of Gucci"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Since its immediate success in 1813, Pride and Prejudice has remained one of the most popular novels in the English language. Jane Austen called this brilliant work \"her own darling child\" and its vivacious heroine, Elizabeth Bennet, \"as delightful a creature as ever appeared in print.\" The romantic clash between the opinionated Elizabeth and her proud beau, Mr. Darcy, is a splendid performance of civilized sparring. And Jane Austen's radiant wit sparkles as her characters dance a delicate quadrille of flirtation and intrigue, making this book the most superb comedy of manners of Regency England.",
                            ImageUrl = "https://readaloudrevival.com/wp-content/uploads/2016/05/Pride-and-Prejudice.png.webp",
                            NumberOfPages = 279,
                            PublicationDate = new DateTime(2000, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Modern Library",
                            Title = "Pride and Prejudice"
                        },
                        new
                        {
                            Id = 6,
                            Description = "In a future so real and near it might be now, something happens when women go to sleep; they become shrouded in a cocoon-like gauze.If they are awakened, and the gauze wrapping their bodies is disturbed or violated, the women become feral and spectacularly violent; and while they sleep they go to another place.The men of our world are abandoned, left to their increasingly primal devices. One woman, however, the mysterious Evie, is immune to the blessing or curse of the sleeping disease.Is Evie a medical anomaly to be studied, or is she a demon who must be slain?",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1510335748i/34466922.jpg",
                            NumberOfPages = 702,
                            PublicationDate = new DateTime(2017, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Hardcover",
                            Title = "Sleeping Beauties"
                        });
                });

            modelBuilder.Entity("BookWise.Infrastructure.Data.Models.BookAuthor", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("BookAuthors");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 1
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 2
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 3
                        },
                        new
                        {
                            BookId = 4,
                            AuthorId = 4
                        },
                        new
                        {
                            BookId = 5,
                            AuthorId = 5
                        },
                        new
                        {
                            BookId = 6,
                            AuthorId = 6
                        },
                        new
                        {
                            BookId = 6,
                            AuthorId = 2
                        });
                });

            modelBuilder.Entity("BookWise.Infrastructure.Data.Models.BookGenre", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("BookGenres");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            GenreId = 1
                        },
                        new
                        {
                            BookId = 1,
                            GenreId = 4
                        },
                        new
                        {
                            BookId = 2,
                            GenreId = 2
                        },
                        new
                        {
                            BookId = 3,
                            GenreId = 4
                        },
                        new
                        {
                            BookId = 4,
                            GenreId = 3
                        },
                        new
                        {
                            BookId = 5,
                            GenreId = 4
                        },
                        new
                        {
                            BookId = 5,
                            GenreId = 5
                        },
                        new
                        {
                            BookId = 6,
                            GenreId = 2
                        });
                });

            modelBuilder.Entity("BookWise.Infrastructure.Data.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Biography"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Classic"
                        });
                });

            modelBuilder.Entity("BookWise.Infrastructure.Data.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            Rating = 5,
                            ReviewText = "i hate to admit it, but the hype is real. i wasnt sure i could trust all of the praise this book is getting because i didnt like the last RY book that was widely loved. but this one is enjoyable!it has all of your typical fantasy tropes - a girl who doesnt know her powerful potential, found families, a magical enemy threatening the kingdom, and enemies to lovers. so nothing about this is super unique. but everything is done really well and is very engaging.this is just one of those books that is a lot of fun to read. so you dont really care about how well its written or the bigger points reviewers usually critique. its just about pure enjoyment.so if you like dragons and youre looking for a new fantasy read with a decent amount of romance, this is the one for you!",
                            UserId = "gs6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                        });
                });

            modelBuilder.Entity("BookWise.Infrastructure.Data.Models.User", b =>
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

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

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

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "admin2856-c198-4129-b3f3-b893d8395082",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "633e11a9-d441-4324-9756-9644be473702",
                            Email = "admin@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Danina",
                            LastName = "Ivanova",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEESQjLoy2EV4b44AYe819/2/699BFAmGptRyXnqMF/DycSQQbTD7xF2q0A5VmI7WyQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9b2c45fd-6eb1-46b0-87d4-d5630415cd78",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "gs6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3fb4b40a-97c6-432d-9303-b3e211741c32",
                            Email = "guest@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Teodora",
                            LastName = "Apostolova",
                            LockoutEnabled = false,
                            NormalizedEmail = "GUEST@GMAIL.COM",
                            NormalizedUserName = "GUEST",
                            PasswordHash = "AQAAAAEAACcQAAAAECrc8H3qGWgTTIRY67u84u+ywVlWuBxKEqeZhirnIW+O3TwDQ6TtmkgNsHgKr/maUw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "539e0dce-73bf-4b60-91e1-5bb3be706293",
                            TwoFactorEnabled = false,
                            UserName = "guest"
                        });
                });

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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BookWise.Infrastructure.Data.Models.BookAuthor", b =>
                {
                    b.HasOne("BookWise.Infrastructure.Data.Models.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookWise.Infrastructure.Data.Models.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BookWise.Infrastructure.Data.Models.BookGenre", b =>
                {
                    b.HasOne("BookWise.Infrastructure.Data.Models.Book", "Book")
                        .WithMany("BookGenres")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookWise.Infrastructure.Data.Models.Genre", "Genre")
                        .WithMany("BookGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("BookWise.Infrastructure.Data.Models.Review", b =>
                {
                    b.HasOne("BookWise.Infrastructure.Data.Models.Book", "Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BookWise.Infrastructure.Data.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
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
                    b.HasOne("BookWise.Infrastructure.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BookWise.Infrastructure.Data.Models.User", null)
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

                    b.HasOne("BookWise.Infrastructure.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BookWise.Infrastructure.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookWise.Infrastructure.Data.Models.Author", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("BookWise.Infrastructure.Data.Models.Book", b =>
                {
                    b.Navigation("BookAuthors");

                    b.Navigation("BookGenres");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("BookWise.Infrastructure.Data.Models.Genre", b =>
                {
                    b.Navigation("BookGenres");
                });

            modelBuilder.Entity("BookWise.Infrastructure.Data.Models.User", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
