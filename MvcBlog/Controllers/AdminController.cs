using MvcBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog.Controllers
{
    public class AdminController : Controller
    {
        MvcBlogDB db = new MvcBlogDB();
        // GET: Admin
        public ActionResult Index()
        {
            var sorgu = db.Kategoris.ToList();
            return View(sorgu);
        }
    }
}