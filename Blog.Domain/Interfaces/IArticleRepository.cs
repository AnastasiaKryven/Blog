using Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Interfaces
{
    public interface IArticleRepository: IDisposable
    {
        Article CreateArticle(Article article);

        IEnumerable<Article> GetAllArticles();

        Article GetArticleById(int articleId);

        void Edit(Article article);
    }
}
