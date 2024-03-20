using BookWise.Infrastructure.Data;
using BookWise.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookWise.Data.Seeding
{
    public class AuthorSeeder : ISeeder
    {
        public async Task SeedAsync(IServiceScope serviceScope)
        {
            var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            if (await dbContext.Authors.AnyAsync())
            {
                return;
            }

            var authors = new List<Author>()
            {
                new Author()
                {
                    FirstName="Rebecca",
                    LastName="Yarros",
                    BirthDate=new DateTime(1981,4,13),
                    ImageUrl="https://api.entangledpublishing.com/storage/authors/author_16672544738496.jpg",
                    Description="Rebecca Yarros is a hopeless romantic and coffee addict. She is the New York Times bestselling author of over twenty novels, including Fourth Wing, The Last Letter and The Things We Leave Unfinished. She’s also the recipient of the Colorado Romance Writer’s Award of Excellence for Eyes Turned Skyward. Rebecca loves military heroes and has been blissfully married to hers for over twenty years. A mother of six, she is currently surviving the teenage years with all four of her hockey-playing sons.",
                },
                new Author()
                {
                    FirstName="Stephen",
                    LastName="King",
                    BirthDate=new DateTime(1947,9,20),
                    ImageUrl="https://m.media-amazon.com/images/M/MV5BMjA2ODIxNDM4Nl5BMl5BanBnXkFtZTYwMjkzMzU1._V1_FMjpg_UX1000_.jpg",
                    Description="Stephen King was born in 1947 in Portland, Maine. Raised primarily by his mother after his father left the family when he was two, King spent parts of his childhood in Indiana and Connecticut before settling in Maine. He attended the University of Maine at Orono, where he was involved in student politics and became a supporter of the anti-war movement during the Vietnam War era. Graduating in 1970 with a degree in English, he married Tabitha Spruce in 1971. King initially struggled to find steady work, taking on jobs like laborer at an industrial laundry. Despite this, he continued to write, making his first professional sale in 1967. In 1971, he began teaching at Hampden Academy while still pursuing his writing career. His early stories appeared in men's magazines and were later compiled into collections like \"Night Shift.\"",
                },
                new Author()
                {
                    FirstName="Emily",
                    LastName="Henry",
                    BirthDate=new DateTime(1993,6,12),
                    ImageUrl="https://images4.penguinrandomhouse.com/author/306512",
                    Description="Emily Henry is the #1 New York Times bestselling author of Book Lovers, People We Meet on Vacation, and Beach Read, as well as the forthcoming Happy Place. She lives and writes in Cincinnati and the part of Kentucky just beneath it.",
                },
                new Author()
                {
                    FirstName="Sara",
                    LastName="Forden",
                    BirthDate=new DateTime(1950,5,19),
                    ImageUrl="https://m.media-amazon.com/images/S/amzn-author-media-prod/m4mrdgmu85gfv47i68pc875a7p._SX450_CR0%2C0%2C450%2C450_.jpg",
                    Description="Sara Gay Forden is an author and a journalist with a knack for digging out compelling stories. Her first published newspaper article told the tale of \"Ma,\" the owner of the Red Lion Diner in Northampton, MA, who fed the down-and-out and went on to found a homeless shelter, becoming a pillar of the community.",
                },
                new Author()
                {
                    FirstName="Jane",
                    LastName="Austen",
                    BirthDate=new DateTime(1775,12,16),
                    ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/c/cc/CassandraAusten-JaneAusten%28c.1810%29_hires.jpg/800px-CassandraAusten-JaneAusten%28c.1810%29_hires.jpg",
                    Description="Jane Austen, renowned for her irony and wit, meticulously dissected middle-class manners and morals in novels like Pride and Prejudice and Emma. Situating her romantic fiction amidst the landed gentry, Austen's keen realism and sharp social commentary earned her widespread recognition among readers and scholars alike.\r\n\r\nRaised within a close-knit family of modest gentry, Austen's upbringing, coupled with her voracious reading, served as her education and artistic foundation. Her family's unwavering support nurtured her development as a writer. Despite facing initial obscurity, Austen persisted in honing her craft, experimenting with literary forms and revising her works until they attained success with Sense and Sensibility and Mansfield Park.",
                },
                new Author()
                {
                    FirstName="Owen",
                    LastName="King",
                    BirthDate=new DateTime(1977,2,21),
                    ImageUrl="https://owen-king.com/wp-content/uploads/2022/07/owen-king-author2.jpg",
                    Description="He is the author of Double Feature and We're All In This Together: A Novella and Stories, co-editor (with John McNally) of the anthology Who Can Save Us Now, and co-author (with Marc Poirier) of the graphic novel Introduction to Alien Invasion is also known for co-writing the novel Sleeping Beauty with Stephen King. Their writing has been featured in publications such as Prairie Schooner, Subtropics, Lady Churchill's Rosebud Wristlet, Ploughshares and One Story.",
                },
                new Author()
                { 
                    FirstName="Mark",
                    LastName="Manson",
                    BirthDate=new DateTime(1984,3,9),
                    ImageUrl="https://upload.wikimedia.org/wikipedia/commons/5/5c/Mark-manson-headshot-2018-1.jpg",
                    Description="Mark Manson (born 1984) is a professional blogger, entrepreneur, and former dating coach. Since 2007, he's been helping people with their emotional and relationship problems. He has worked with thousands of people from over 30 different countries.",
                }
            };

            await dbContext.Authors.AddRangeAsync(authors);
            await dbContext.SaveChangesAsync();
        }
    }
}
