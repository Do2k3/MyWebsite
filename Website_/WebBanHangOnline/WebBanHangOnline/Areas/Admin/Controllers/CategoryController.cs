﻿using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;
using WebBanHangOnline.Models.EF;

namespace WebBanHangOnline.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();
        // GET: Admin/Category
        public ActionResult Index()
        {
            var items = _dbContext.Categories;
            return View(items);
        }

        public ActionResult Add() 
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Category model)
        {
            if (ModelState.IsValid) 
            {
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                model.Alias = WebBanHangOnline.Models.Common.Filter.FilterChar(model.Title);
                _dbContext.Categories.Add(model);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Edit( int id) 
        {
            var item = _dbContext.Categories.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category model)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Categories.Attach(model);
                model.ModifiedDate = DateTime.Now;

                model.Alias = WebBanHangOnline.Models.Common.Filter.FilterChar(model.Title);
                _dbContext.Entry(model).Property(x => x.Title).IsModified = true;
                _dbContext.Entry(model).Property(x => x.Description).IsModified = true;
                _dbContext.Entry(model).Property(x => x.Alias).IsModified = true;
                _dbContext.Entry(model).Property(x => x.SeoDescription).IsModified = true;
                _dbContext.Entry(model).Property(x => x.SeoTitle).IsModified = true;
                _dbContext.Entry(model).Property(x => x.SeoKeywords).IsModified = true;
                _dbContext.Entry(model).Property(x => x.Position).IsModified = true;
                _dbContext.Entry(model).Property(x => x.ModifiedDate).IsModified = true;
                _dbContext.Entry(model).Property(x => x.ModifiedBy).IsModified = true;
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]               
        public ActionResult Delete(int id)
        {
            var item = _dbContext.Categories.Find(id);
            if (item != null)
            {
                _dbContext.Categories.Remove(item);
                _dbContext.SaveChanges();
                return Json(new { success = true });
            }    
            return Json(new { success = false });
        }
    }
}