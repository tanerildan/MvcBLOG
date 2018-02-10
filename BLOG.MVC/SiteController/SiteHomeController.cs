﻿using BLOG.DAL.Entities;
using BLOG.MVC.Models;
using BLOG.Repository.UOW.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BLOG.MVC.SiteController
{
    public class SiteHomeController : Controller
    {
        private readonly IUnitofWork _uow;
        public SiteHomeController(IUnitofWork uow)
        {
            _uow = uow;
        }
        // GET: SiteHome
      
        public ActionResult Home()
        {
            PostCommentModel model = new PostCommentModel();
            model.Posts = _uow.GetRepo<Post>().GetList();
         return View(model);
        }

        public ActionResult PostView(int id)
        {
            var data = _uow.GetRepo<Post>().Where(x => x.Id == id
           ).FirstOrDefault();
           
            return View(data);
        }
           
        }
    }
