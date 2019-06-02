using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string DateArticle { get; set; }
        public string Name { get; set; }
        public string TextOfArticle { get; set; }

        public Article()
        {
            DateArticle = DateTime.Now.ToString();
        }
    }
}
