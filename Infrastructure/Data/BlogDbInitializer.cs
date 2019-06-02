using Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class BlogDbInitializer : CreateDatabaseIfNotExists<BlogContext>
    {
        public int counter = 1;

        protected override void Seed(BlogContext db)
        {
            db.Anketas.Add(
                 new Anketa
                 {
                     AnketaId = 1,
                     Name = "Nastya",
                     Surname = "Kriven",
                     Sex = "Female",
                 }
                );
            db.Anketas.Add(
                new Anketa
                {
                    AnketaId = 2,
                    Name = "Alla",
                    Surname = "Ivanova",
                    Sex = "Female",
                });


            db.Articles.Add(new Article
            {
                ArticleId = counter++,
                Name = "New 1",
                DateArticle = "2019.05.22",
                TextOfArticle = "Blah Blah Blah"
            }
                );

            db.Articles.Add(
                 new Article
                 {
                     ArticleId = counter++,
                     Name = "New 2",
                     DateArticle = "2019.05.23",
                     TextOfArticle = "La la la"
                 }
                );

            db.Requests.Add(
            new Request
            {
                Name = "Anna",
                Email = "Alla@gmail.com",
                DateRequest = "2019.02.22",
                TextOfRequest = "Very well"
            });
            db.Requests.Add(
               new Request
               {
                   Name = "Alla",
                   Email = "Alla@gmail.com",
                   DateRequest = "2019.02.22",
                   TextOfRequest = "Very well"
               });
            base.Seed(db);
        }
    }
}
