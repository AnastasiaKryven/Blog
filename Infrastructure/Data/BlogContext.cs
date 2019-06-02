using Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class BlogContext : DbContext
    {
        public DbSet<Anketa> Anketas { get; set; }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Request> Requests { get; set; }
    }
}
