﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        ContentManager cm = new ContentManager(new EfContentDal());
        public ActionResult Index()
        {
            return View();
        }
        Context c = new Context();
        public ActionResult GetAllContent(string p)
        {
            if (p == null)
            {
                var all = c.Contents.ToList();
                return View(all);

            }
            else
            {
                var values = cm.GetList(p);
                return View(values.ToList());

            }

            //var values = c.Contents.ToList();

        }
        public ActionResult ContentByHeading(int id)
        {
            var contentvalues = cm.GetListByHeadingID(id);
            return View(contentvalues);
        }
    }
}