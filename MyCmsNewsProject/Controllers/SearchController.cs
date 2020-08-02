using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;
namespace MyCmsNewsProject.Controllers
{
    public class SearchController : Controller
    {
        private IPageRepository pageRepository;
        MyCmsContext db = new MyCmsContext();
        public SearchController()
        {
            pageRepository = new PageRepository(db);
        }
        // GET: Search
        public ActionResult Index(string q)
        {
            ViewBag.name = q;
            return View(pageRepository.SearchPage(q));
        }
    }
}