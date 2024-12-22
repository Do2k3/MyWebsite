using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;
using WebBanHangOnline.Models.EF;

namespace WebBanHangOnline.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();
        // GET: Admin/Products
        public ActionResult Index(int? page)
        {

            var pageSize = 10;
            if (page == null)
            {
                page = 1;
            }
            IEnumerable<Products> item = _dbContext.Products.OrderByDescending(x => x.Id);
            
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            item = item.ToPagedList(pageIndex, pageSize);
            ViewBag.Page = page;
            ViewBag.PageSize = pageSize;
            return View(item);
        }

        public ActionResult Add()
        {
            ViewBag.ProductCategory = new SelectList(_dbContext.ProductCategories.ToList(),"Id","Title");
            return View();
        }
    }
}