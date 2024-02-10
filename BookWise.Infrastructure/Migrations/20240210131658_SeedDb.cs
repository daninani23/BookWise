using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookWise.Infrastructure.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    NumberOfPages = table.Column<int>(type: "int", nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => new { x.BookId, x.AuthorId });
                    table.ForeignKey(
                        name: "FK_BookAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewText = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookGenres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenres", x => new { x.BookId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_BookGenres_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "admin2856-c198-4129-b3f3-b893d8395082", 0, "abc011b3-d32a-40f8-8434-0c97ac96f83a", "admin@mail.com", false, "Danina", "Ivanova", false, null, "ADMIN@MAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAENpDLs6Ua8Pgp8FsVg6mueum+/d4wXIDxEih0xfAKR7Usr60vT82qm78M/lnQuKXvA==", null, false, "ddfc2fdf-92d1-4bbf-9bf1-12ba100d15a3", false, "admin" },
                    { "gs6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "e91295e9-2bdc-48d4-b1b1-14060c2aa4c0", "guest@mail.com", false, "Teodora", "Apostolova", false, null, "GUEST@GMAIL.COM", "GUEST", "AQAAAAEAACcQAAAAEPOmCskkbjVSNiwi8gMcihQMtk5q79ZeGq/r9hDHQyqw4OX47NJhtbos4NV9Dxfx8Q==", null, false, "aac06a45-6d75-4309-b426-8f075b65c1d0", false, "guest" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "FirstName", "ImageUrl", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1981, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rebecca", "https://api.entangledpublishing.com/storage/authors/author_16672544738496.jpg", "Yarros" },
                    { 2, new DateTime(1947, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephen", "https://m.media-amazon.com/images/M/MV5BMjA2ODIxNDM4Nl5BMl5BanBnXkFtZTYwMjkzMzU1._V1_FMjpg_UX1000_.jpg", "King" },
                    { 3, new DateTime(1993, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emily", "https://images4.penguinrandomhouse.com/author/306512", "Henry" },
                    { 4, new DateTime(1950, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sara", "https://m.media-amazon.com/images/S/amzn-author-media-prod/m4mrdgmu85gfv47i68pc875a7p._SX450_CR0%2C0%2C450%2C450_.jpg", "Forden" },
                    { 5, new DateTime(1775, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cc/CassandraAusten-JaneAusten%28c.1810%29_hires.jpg/800px-CassandraAusten-JaneAusten%28c.1810%29_hires.jpg", "Austen" },
                    { 6, new DateTime(1977, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Owen", "https://owen-king.com/wp-content/uploads/2022/07/owen-king-author2.jpg", "King" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Description", "ImageUrl", "NumberOfPages", "PublicationDate", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, "Twenty-year-old Violet Sorrengail was supposed to enter the Scribe Quadrant, living a quiet life among books and history. Now, the commanding general also known as her tough as talons mother has ordered Violet to join the hundreds of candidates striving to become the elite of Navarre: dragon riders.But when you’re smaller than everyone else and your body is brittle, death is only a heartbeat away...because dragons don’t bond to “fragile” humans. They incinerate them.With fewer dragons willing to bond than cadets, most would kill Violet to better their own chances of success. The rest would kill her just for being her mother’s daughter like Xaden Riorson, the most powerful and ruthless wingleader in the Riders Quadrant.She’ll need every edge her wits can give her just to see the next sunrise.Yet, with every day that passes, the war outside grows more deadly, the kingdom's protective wards are failing, and the death toll continues to rise. Even worse, Violet begins to suspect leadership is hiding a terrible secret.Friends, enemies, lovers. Everyone at Basgiath War College has an agenda because once you enter, there are only two ways out: graduate or die.", "https://upload.wikimedia.org/wikipedia/en/d/dd/Fourth_Wing_Cover_Art.jpeg", 498, new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Tower Books", "Fourth Wing" },
                    { 2, "In the middle of the night, in a house on a quiet street in suburban Minneapolis, intruders silently murder Luke Ellis’s parents and load him into a black SUV. The operation takes less than two minutes. Luke will wake up at The Institute, in a room that looks just like his own, except there’s no window. And outside his door are other doors, behind which are other kids with special talents telekinesis and telepathy who got to this place the same way Luke did: Kalisha, Nick, George, Iris, and ten-year-old Avery Dixon. They are all in Front Half. Others, Luke learns, graduated to Back Half, “like the roach motel,” Kalisha says. “You check in, but you don’t check out.” In this most sinister of institutions, the director, Mrs. Sigsby, and her staff are ruthlessly dedicated to extracting from these children the force of their extranormal gifts. There are no scruples here. If you go along, you get tokens for the vending machines. If you don’t, punishment is brutal. As each new victim disappears to Back Half, Luke becomes more and more desperate to get out and get help. But no one has ever escaped from the Institute.As psychically terrifying as Firestarter, and with the spectacular kid power of It, The Institute is Stephen King's gut-wrenchingly dramatic story of good versus evil in a world where the good guys don't always win.", "https://upload.wikimedia.org/wikipedia/en/0/00/The_Institute_%28King_novel%29.png", 576, new DateTime(2019, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scribner", "The Institute" },
                    { 3, "Poppy and Alex. Alex and Poppy. They have nothing in common. She’s a wild child; he wears khakis. She has insatiable wanderlust; he prefers to stay home with a book. And somehow, ever since a fateful car share home from college many years ago, they are the very best of friends. For most of the year they live far apart she’s in New York City, and he’s in their small hometown but every summer, for a decade, they have taken one glorious week of vacation together. Until two years ago, when they ruined everything. They haven’t spoken since. Poppy has everything she should want, but she’s stuck in a rut. When someone asks when she was last truly happy, she knows, without a doubt, it was on that ill-fated, final trip with Alex. And so, she decides to convince her best friend to take one more vacation together lay everything on the table, make it all right. Miraculously, he agrees. Now she has a week to fix everything. If only she can get around the one big truth that has always stood quietly in the middle of their seemingly perfect relationship. What could possibly go wrong?", "https://upload.wikimedia.org/wikipedia/en/2/20/People_We_Meet_on_Vacation.jpg", 364, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Berkley Books", "People We Meet on Vacation" },
                    { 4, " On the morning of March 27, 1995, four quick shots cracked through Milan’s elegant streets. Maurizio Gucci, heir to the fabulous fashion dynasty, had been ambushed, slain on the steps to his office by an unknown gunman. Two years later, Milan’s chief of police entered the sumptuous palazzo of Maurizio’s ex-wife, Patrizia Reggiani nicknamed “the Black Widow” by the press and arrested her for the murder. Did Patrizia kill her ex-husband because his spending was wildly out of control? Did she do it because he was preparing to marry his mistress? Or is it possible Patrizia didn’t do it at all? The Gucci story is one of glitz, glamour, and intrigue a chronicle of the rise, near fall, and subsequent resurgence of a fashion dynasty. Beautifully written, impeccably researched, and widely acclaimed, The House of Gucci is a page-turning account of high fashion, high finance, and heartrending personal tragedy.", "https://prodimage.images-bn.com/pimages/9788811004349_p0_v1_s1200x630.jpg", 288, new DateTime(2000, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariner Books", "The House of Gucci" },
                    { 5, "Since its immediate success in 1813, Pride and Prejudice has remained one of the most popular novels in the English language. Jane Austen called this brilliant work \"her own darling child\" and its vivacious heroine, Elizabeth Bennet, \"as delightful a creature as ever appeared in print.\" The romantic clash between the opinionated Elizabeth and her proud beau, Mr. Darcy, is a splendid performance of civilized sparring. And Jane Austen's radiant wit sparkles as her characters dance a delicate quadrille of flirtation and intrigue, making this book the most superb comedy of manners of Regency England.", "https://readaloudrevival.com/wp-content/uploads/2016/05/Pride-and-Prejudice.png.webp", 279, new DateTime(2000, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modern Library", "Pride and Prejudice" },
                    { 6, "In a future so real and near it might be now, something happens when women go to sleep; they become shrouded in a cocoon-like gauze.If they are awakened, and the gauze wrapping their bodies is disturbed or violated, the women become feral and spectacularly violent; and while they sleep they go to another place.The men of our world are abandoned, left to their increasingly primal devices. One woman, however, the mysterious Evie, is immune to the blessing or curse of the sleeping disease.Is Evie a medical anomaly to be studied, or is she a demon who must be slain?", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1510335748i/34466922.jpg", 702, new DateTime(2017, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hardcover", "Sleeping Beauties" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fantasy" },
                    { 2, "Horror" },
                    { 3, "Biography" },
                    { 4, "Romance" },
                    { 5, "Classic" }
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 2, 6 },
                    { 6, 6 }
                });

            migrationBuilder.InsertData(
                table: "BookGenres",
                columns: new[] { "BookId", "GenreId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 4 },
                    { 2, 2 },
                    { 3, 4 },
                    { 4, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "Rating", "ReviewText", "UserId" },
                values: new object[] { 1, 1, 5, "i hate to admit it, but the hype is real. i wasnt sure i could trust all of the praise this book is getting because i didnt like the last RY book that was widely loved. but this one is enjoyable!it has all of your typical fantasy tropes - a girl who doesnt know her powerful potential, found families, a magical enemy threatening the kingdom, and enemies to lovers. so nothing about this is super unique. but everything is done really well and is very engaging.this is just one of those books that is a lot of fun to read.", "gs6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" });

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BookAuthors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenres_GenreId",
                table: "BookGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.DropTable(
                name: "BookGenres");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin2856-c198-4129-b3f3-b893d8395082");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "gs6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
