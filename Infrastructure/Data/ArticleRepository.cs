using Blog.Domain.Entities;
using Blog.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ArticleRepository : IArticleRepository
    {
        private BlogContext db = new BlogContext();

        Article IArticleRepository.CreateArticle(Article article)
        {
            db.Articles.Add(article);
            db.SaveChanges();

            return article;
        }

        #region IDisposable Support
        private bool disposedValue = false; // Для определения избыточных вызовов

        public IEnumerable<Article> Articl { get { return db.Articles; } }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты).
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
            }
        }

        // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
        // ~BlogRepository() {
        //   // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
        //   Dispose(false);
        // }

        // Этот код добавлен для правильной реализации шаблона высвобождаемого класса.
        void IDisposable.Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
            Dispose(true);
            // TODO: раскомментировать следующую строку, если метод завершения переопределен выше.
            // GC.SuppressFinalize(this);
        }
        #endregion
        public IEnumerable<Article> GetAllArticles()
        {
            return db.Articles;
        }

        public void Edit(Article article)
        {
            var currentArticle = db.Set<Article>().Find(article.ArticleId);

            currentArticle.Name = article.Name;
            currentArticle.TextOfArticle = article.TextOfArticle;

            db.Entry(currentArticle).State = EntityState.Modified;
            db.SaveChanges();            
        }

        public Article GetArticleById(int articleId)
        {
            return db.Set<Article>().Find(articleId) ?? throw new ArgumentNullException(null, "Such article does not found!");
        }       
    }
}
