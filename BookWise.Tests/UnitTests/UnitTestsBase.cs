using BookWise.Data.Models;
using BookWise.Infrastructure.Data;
using BookWise.Infrastructure.Data.Common;
using BookWise.Infrastructure.Data.Models;
using BookWise.Tests.Mocks;
using Microsoft.AspNetCore.Identity;

namespace BookWise.Tests.UnitTests
{
    public class UnitTestsBase
    {
        protected ApplicationDbContext context;
        protected IRepository repository;

        [OneTimeSetUp]
        public void SetUpBase()
        {
            context = DatabaseMock.Instance;
            repository = new Repository(context);
            SeedDatabase(repository);
        }

        public ApplicationUser AppUser1 { get; private set; }
        public ApplicationUser AppUser2 { get; private set; }

        public Genre Genre1 { get; private set; }
        public Genre Genre2 { get; private set; }
        public Genre Genre3 { get; private set; }

        public Book Book1 { get; private set; }
        public Book Book2 { get; private set; }

        public Author Author1 { get; private set; }
        public Author Author2 { get; private set; }

        public Review Review1 { get; private set; }

        public BookGenre BookGenre1 { get; private set; }
        public BookGenre BookGenre2 { get; private set; }
        public BookGenre BookGenre3 { get; private set; }

        public BookAuthor BookAuthor1 { get; private set; }
        public BookAuthor BookAuthor2 { get; private set; }

        private void SeedDatabase(IRepository repo)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            AppUser1 = new ApplicationUser
            {
                Id = "b9c05e8a-940d-4d40-bfac-cc1691e4af42",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM",
                FirstName = "Danina",
                LastName = "Ivanova",
            };
            AppUser1.PasswordHash = hasher.HashPassword(AppUser1, "admin123");

            AppUser2 = new ApplicationUser
            {
                Id = "315a868a-d0a9-437b-b39f-f3296b83bb1b",
                UserName = "guest",
                NormalizedUserName = "GUEST",
                Email = "guest@mail.com",
                NormalizedEmail = "GUEST@GMAIL.COM",
                FirstName = "Teodora",
                LastName = "Apostolova",
            };

            AppUser2.PasswordHash = hasher.HashPassword(AppUser2, "guest123");

            Author1 = new Author()
            {
                FirstName = "Rebecca",
                LastName = "Yarros",
                BirthDate = new DateTime(1981, 4, 13),
                ImageUrl = "https://api.entangledpublishing.com/storage/authors/author_16672544738496.jpg",
                Description = "Rebecca Yarros is a hopeless romantic and coffee addict. She is the New York Times bestselling author of over twenty novels, including Fourth Wing, The Last Letter and The Things We Leave Unfinished. She’s also the recipient of the Colorado Romance Writer’s Award of Excellence for Eyes Turned Skyward. Rebecca loves military heroes and has been blissfully married to hers for over twenty years. A mother of six, she is currently surviving the teenage years with all four of her hockey-playing sons.",
            };

            Author2 = new Author()
            {
                FirstName = "Stephen",
                LastName = "King",
                BirthDate = new DateTime(1947, 9, 20),
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjA2ODIxNDM4Nl5BMl5BanBnXkFtZTYwMjkzMzU1._V1_FMjpg_UX1000_.jpg",
                Description = "Stephen King was born in 1947 in Portland, Maine. Raised primarily by his mother after his father left the family when he was two, King spent parts of his childhood in Indiana and Connecticut before settling in Maine. He attended the University of Maine at Orono, where he was involved in student politics and became a supporter of the anti-war movement during the Vietnam War era. Graduating in 1970 with a degree in English, he married Tabitha Spruce in 1971. King initially struggled to find steady work, taking on jobs like laborer at an industrial laundry. Despite this, he continued to write, making his first professional sale in 1967. In 1971, he began teaching at Hampden Academy while still pursuing his writing career. His early stories appeared in men's magazines and were later compiled into collections like \"Night Shift.\"",
            };

            Book1 = new Book()
            {
                Title = "Fourth Wing",
                Description = "Twenty-year-old Violet Sorrengail was supposed to enter the Scribe Quadrant, living a quiet life among books and history. Now, the commanding general also known as her tough as talons mother has ordered Violet to join the hundreds of candidates striving to become the elite of Navarre: dragon riders.But when you’re smaller than everyone else and your body is brittle, death is only a heartbeat away...because dragons don’t bond to “fragile” humans. They incinerate them.With fewer dragons willing to bond than cadets, most would kill Violet to better their own chances of success. The rest would kill her just for being her mother’s daughter like Xaden Riorson, the most powerful and ruthless wingleader in the Riders Quadrant.She’ll need every edge her wits can give her just to see the next sunrise.Yet, with every day that passes, the war outside grows more deadly, the kingdom's protective wards are failing, and the death toll continues to rise. Even worse, Violet begins to suspect leadership is hiding a terrible secret.Friends, enemies, lovers. Everyone at Basgiath War College has an agenda because once you enter, there are only two ways out: graduate or die.",
                NumberOfPages = 498,
                Publisher = "Red Tower Books",
                PublicationDate = new DateTime(2023, 4, 5),
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/dd/Fourth_Wing_Cover_Art.jpeg"
            };

            Book2 = new Book()
            {
                Title = "The Institute",
                Description = "In the middle of the night, in a house on a quiet street in suburban Minneapolis, intruders silently murder Luke Ellis’s parents and load him into a black SUV. The operation takes less than two minutes. Luke will wake up at The Institute, in a room that looks just like his own, except there’s no window. And outside his door are other doors, behind which are other kids with special talents telekinesis and telepathy who got to this place the same way Luke did: Kalisha, Nick, George, Iris, and ten-year-old Avery Dixon. They are all in Front Half. Others, Luke learns, graduated to Back Half, “like the roach motel,” Kalisha says. “You check in, but you don’t check out.” In this most sinister of institutions, the director, Mrs. Sigsby, and her staff are ruthlessly dedicated to extracting from these children the force of their extranormal gifts. There are no scruples here. If you go along, you get tokens for the vending machines. If you don’t, punishment is brutal. As each new victim disappears to Back Half, Luke becomes more and more desperate to get out and get help. But no one has ever escaped from the Institute.As psychically terrifying as Firestarter, and with the spectacular kid power of It, The Institute is Stephen King's gut-wrenchingly dramatic story of good versus evil in a world where the good guys don't always win.",
                NumberOfPages = 576,
                Publisher = "Scribner",
                PublicationDate = new DateTime(2019, 9, 10),
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/00/The_Institute_%28King_novel%29.png"
            };

            Genre1 = new Genre()
            {
                Name = "Fantasy"
            };
            Genre2 = new Genre()
            {
                Name = "Romance"
            };
            Genre3 = new Genre()
            {
                Name = "Horror"
            };
            BookGenre1 = new BookGenre()
            {
                BookId = 1,
                GenreId = 1,
            };
            BookGenre2 = new BookGenre()
            {
                BookId = 1,
                GenreId = 2,
            };
            BookGenre3 = new BookGenre()
            {
                BookId = 2,
                GenreId = 3,
            };
            BookAuthor1 = new BookAuthor()
            {
                BookId = 1,
                AuthorId = 1,
            };
            BookAuthor2 = new BookAuthor()
            {
                BookId = 2,
                AuthorId = 2,
            };

            Review1 = new Review
            {
                BookId = 1,
                Rating = 5,
                ReviewText="I like it a lot",
                UserId= "315a868a-d0a9-437b-b39f-f3296b83bb1b"

            };

            repo.AddAsync(Book1);
            repo.AddAsync(Book2);
            repo.AddAsync(Genre1);
            repo.AddAsync(Genre2);
            repo.AddAsync(Genre3);
            repo.AddAsync(AppUser1);
            repo.AddAsync(AppUser2);
            repo.AddAsync(Author1);
            repo.AddAsync(Author2);
            repo.AddAsync(BookAuthor1);
            repo.AddAsync(BookAuthor2);
            repo.AddAsync(BookGenre1);
            repo.AddAsync(BookGenre2);
            repo.AddAsync(BookGenre3);
            repo.AddAsync(Review1);
            repo.SaveChangesAsync();
        }
        [OneTimeTearDown]
        public void TearDownBase() => context.Dispose();
    }
}
