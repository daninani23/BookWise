using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookWise.Infrastructure.Data.Models;

namespace BookWise.Infrastructure.Data.Configuration
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(CreateBooks());
        }

        private List<Book> CreateBooks()
        {
            var books = new List<Book>()
            {
                new Book(){
                    Id = 1,
                    Title="Fourth Wing",
                    Description="Twenty-year-old Violet Sorrengail was supposed to enter the Scribe Quadrant, living a quiet life among books and history. Now, the commanding general also known as her tough as talons mother has ordered Violet to join the hundreds of candidates striving to become the elite of Navarre: dragon riders.But when you’re smaller than everyone else and your body is brittle, death is only a heartbeat away...because dragons don’t bond to “fragile” humans. They incinerate them.With fewer dragons willing to bond than cadets, most would kill Violet to better their own chances of success. The rest would kill her just for being her mother’s daughter like Xaden Riorson, the most powerful and ruthless wingleader in the Riders Quadrant.She’ll need every edge her wits can give her just to see the next sunrise.Yet, with every day that passes, the war outside grows more deadly, the kingdom's protective wards are failing, and the death toll continues to rise. Even worse, Violet begins to suspect leadership is hiding a terrible secret.Friends, enemies, lovers. Everyone at Basgiath War College has an agenda because once you enter, there are only two ways out: graduate or die.",
                    NumberOfPages=498,
                    Publisher="Red Tower Books",
                    PublicationDate=new DateTime(2023,4,5),
                    ImageUrl="https://upload.wikimedia.org/wikipedia/en/d/dd/Fourth_Wing_Cover_Art.jpeg"
                },
                new Book()
                {
                    Id = 2,
                    Title="The Institute",
                    Description="In the middle of the night, in a house on a quiet street in suburban Minneapolis, intruders silently murder Luke Ellis’s parents and load him into a black SUV. The operation takes less than two minutes. Luke will wake up at The Institute, in a room that looks just like his own, except there’s no window. And outside his door are other doors, behind which are other kids with special talents telekinesis and telepathy who got to this place the same way Luke did: Kalisha, Nick, George, Iris, and ten-year-old Avery Dixon. They are all in Front Half. Others, Luke learns, graduated to Back Half, “like the roach motel,” Kalisha says. “You check in, but you don’t check out.” In this most sinister of institutions, the director, Mrs. Sigsby, and her staff are ruthlessly dedicated to extracting from these children the force of their extranormal gifts. There are no scruples here. If you go along, you get tokens for the vending machines. If you don’t, punishment is brutal. As each new victim disappears to Back Half, Luke becomes more and more desperate to get out and get help. But no one has ever escaped from the Institute.As psychically terrifying as Firestarter, and with the spectacular kid power of It, The Institute is Stephen King's gut-wrenchingly dramatic story of good versus evil in a world where the good guys don't always win.",
                    NumberOfPages= 576,
                    Publisher="Scribner",
                    PublicationDate=new DateTime(2019,9,10),
                    ImageUrl="https://upload.wikimedia.org/wikipedia/en/0/00/The_Institute_%28King_novel%29.png"
                },
                new Book()
                {
                    Id= 3,
                    Title="People We Meet on Vacation",
                    Description="Poppy and Alex. Alex and Poppy. They have nothing in common. She’s a wild child; he wears khakis. She has insatiable wanderlust; he prefers to stay home with a book. And somehow, ever since a fateful car share home from college many years ago, they are the very best of friends. For most of the year they live far apart she’s in New York City, and he’s in their small hometown but every summer, for a decade, they have taken one glorious week of vacation together. Until two years ago, when they ruined everything. They haven’t spoken since. Poppy has everything she should want, but she’s stuck in a rut. When someone asks when she was last truly happy, she knows, without a doubt, it was on that ill-fated, final trip with Alex. And so, she decides to convince her best friend to take one more vacation together lay everything on the table, make it all right. Miraculously, he agrees. Now she has a week to fix everything. If only she can get around the one big truth that has always stood quietly in the middle of their seemingly perfect relationship. What could possibly go wrong?",
                    NumberOfPages=364,
                    Publisher="Berkley Books",
                    PublicationDate=new DateTime(2021,5,11),
                    ImageUrl="https://upload.wikimedia.org/wikipedia/en/2/20/People_We_Meet_on_Vacation.jpg"
                },
                new Book()
                {
                    Id= 4,
                    Title="The House of Gucci",
                    Description=" On the morning of March 27, 1995, four quick shots cracked through Milan’s elegant streets. Maurizio Gucci, heir to the fabulous fashion dynasty, had been ambushed, slain on the steps to his office by an unknown gunman. Two years later, Milan’s chief of police entered the sumptuous palazzo of Maurizio’s ex-wife, Patrizia Reggiani nicknamed “the Black Widow” by the press and arrested her for the murder. Did Patrizia kill her ex-husband because his spending was wildly out of control? Did she do it because he was preparing to marry his mistress? Or is it possible Patrizia didn’t do it at all? The Gucci story is one of glitz, glamour, and intrigue a chronicle of the rise, near fall, and subsequent resurgence of a fashion dynasty. Beautifully written, impeccably researched, and widely acclaimed, The House of Gucci is a page-turning account of high fashion, high finance, and heartrending personal tragedy.",
                    NumberOfPages=288,
                    Publisher="Mariner Books",
                    PublicationDate=new DateTime(2000,8,22),
                    ImageUrl="https://prodimage.images-bn.com/pimages/9788811004349_p0_v1_s1200x630.jpg"
                },
                new Book()
                {
                    Id= 5,
                    Title="Pride and Prejudice",
                    Description="Since its immediate success in 1813, Pride and Prejudice has remained one of the most popular novels in the English language. Jane Austen called this brilliant work \"her own darling child\" and its vivacious heroine, Elizabeth Bennet, \"as delightful a creature as ever appeared in print.\" The romantic clash between the opinionated Elizabeth and her proud beau, Mr. Darcy, is a splendid performance of civilized sparring. And Jane Austen's radiant wit sparkles as her characters dance a delicate quadrille of flirtation and intrigue, making this book the most superb comedy of manners of Regency England.",
                    NumberOfPages=279,
                    Publisher="Modern Library",
                    PublicationDate=new DateTime(2000,10,9),
                    ImageUrl="https://readaloudrevival.com/wp-content/uploads/2016/05/Pride-and-Prejudice.png.webp"
                },
                new Book()
                {
                    Id= 6,
                    Title="Sleeping Beauties",
                    Description="In a future so real and near it might be now, something happens when women go to sleep; they become shrouded in a cocoon-like gauze.If they are awakened, and the gauze wrapping their bodies is disturbed or violated, the women become feral and spectacularly violent; and while they sleep they go to another place.The men of our world are abandoned, left to their increasingly primal devices. One woman, however, the mysterious Evie, is immune to the blessing or curse of the sleeping disease.Is Evie a medical anomaly to be studied, or is she a demon who must be slain?",
                    NumberOfPages=702,
                    Publisher="Hardcover",
                    PublicationDate=new DateTime(2017,9,26),
                    ImageUrl="https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1510335748i/34466922.jpg"
                }
            };

            return books;
        }
    }
}
