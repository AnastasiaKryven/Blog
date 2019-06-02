using Blog.Domain.Entities;
using Blog.Domain.Interfaces;
using Infrastructure.Data;
using System.Web.Mvc;

namespace Blog.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IArticleRepository articleRepository = new ArticleRepository();
        IRequestRepository requestRepository = new RequestRepository();

        public HomeController()
        {
        }


        [HttpGet]
        public ActionResult Index()
        {
            articleRepository.GetAllArticles();
            ViewBag.Articles = articleRepository.GetAllArticles();
            return View();
        }

        [HttpGet]
        public ActionResult About(Request request)
        {
            //BlogContext db = new BlogContext();
            //var req = db.Requests;
            //ViewBag.Requests = req;
            requestRepository.GetAllRequests();
            ViewBag.Requests = requestRepository.GetAllRequests();
            return View();
        }

        [HttpGet]
        public ActionResult AddFeedback()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddFeedback(Request request)
        {
            //db.Requests.Add(request);
            //db.SaveChanges();
            //ReqViewModel req = new ReqViewModel();
            //req.CreateRequest(request);
            requestRepository.Create(request);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your page.";
            return View();
        }

        [HttpPost]
        public string Contact(string Name, string Surname)
        {
            string Answer = $@"{Name} {Surname}, Ваша информация сохранена! ";
            return Answer;
        }

        [HttpGet]
        public ActionResult CreateArticle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateArticle(Article article )
        {
            //ArtViewModel a = new ArtViewModel();
            //a.CreateArticle(article);
            //article = new Article();            
            //articleRepository.CreateArticle(article);
            // var a = db.Articles;
            //db.Articles.Add(article);
            //db.SaveChanges();
            articleRepository.CreateArticle(article);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditArticle(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var article = articleRepository.GetArticleById(id.Value);

            return View(article);
        }


        [HttpPost]
        public ActionResult EditArticle(Article article)
        {
            //db.Entry(article).State = EntityState.Modified;
            //db.SaveChanges();
            articleRepository.Edit(article);
            return RedirectToAction("Index");
        }

    }
}