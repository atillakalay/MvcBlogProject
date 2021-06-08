﻿using System.Collections.Generic;
using System.Linq;
using Business.Concrete;
using System.Web.Mvc;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using PagedList;

namespace MvcBlogProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        private BlogManager _blogManager = new BlogManager(new EfBlogDal());
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult BlogList(int page = 1)
        {
            var result = _blogManager.GetAll().ToPagedList(page, 9);
            return PartialView(result);
        }

        public PartialViewResult FeaturedPosts()
        {
            //1. Post
            var resultTitle = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 1).Select(x => x.BlogTitle).FirstOrDefault();
            var resultImage = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 1).Select(x => x.BlogImage).FirstOrDefault();
            var resultDate = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 1).Select(x => x.BlogDate).FirstOrDefault();

            ViewBag.postTitle1 = resultTitle;
            ViewBag.postImage1 = resultImage;
            ViewBag.postDate1 = resultDate;

            //2. Post
            var resultTitle1 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 2).Select(x => x.BlogTitle).FirstOrDefault();
            var resultImage1 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 2).Select(x => x.BlogImage).FirstOrDefault();
            var resultDate1 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 2).Select(x => x.BlogDate).FirstOrDefault();

            ViewBag.postTitle2 = resultTitle1;
            ViewBag.postImage2 = resultImage1;
            ViewBag.postDate2 = resultDate1;

            //3. Post
            var resultTitle2 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 3).Select(x => x.BlogTitle).FirstOrDefault();
            var resultImage2 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 3).Select(x => x.BlogImage).FirstOrDefault();
            var resultDate2 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 3).Select(x => x.BlogDate).FirstOrDefault();

            ViewBag.postTitle3 = resultTitle2;
            ViewBag.postImage3 = resultImage2;
            ViewBag.postDate3 = resultDate2;

            //4. Post
            var resultTitle3 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 4).Select(x => x.BlogTitle).FirstOrDefault();
            var resultImage3 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 4).Select(x => x.BlogImage).FirstOrDefault();
            var resultDate3 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 4).Select(x => x.BlogDate).FirstOrDefault();

            ViewBag.postTitle4 = resultTitle3;
            ViewBag.postImage4 = resultImage3;
            ViewBag.postDate4 = resultDate3;

            //5. Post
            var resultTitle4 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 5).Select(x => x.BlogTitle).FirstOrDefault();
            var resultImage4 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 5).Select(x => x.BlogImage).FirstOrDefault();
            var resultDate4 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 5).Select(x => x.BlogDate).FirstOrDefault();

            ViewBag.postTitle5 = resultTitle4;
            ViewBag.postImage5 = resultImage4;
            ViewBag.postDate5 = resultDate4;

            return PartialView();
        }

        public PartialViewResult OtherFeaturedPosts()
        {
            return PartialView();
        }

        public ActionResult BlogDetails(int id)
        {
            return View();
        }

        public PartialViewResult BlogCover(int id)
        {
            var result = _blogManager.BlogById(id);
            return PartialView(result);
        }
        public PartialViewResult BlogReadAll(int id)
        {
            var result = _blogManager.BlogById(id);
            return PartialView(result);
        }
        public ActionResult BlogByCategory(int id)
        {
            var blogListByCategory = _blogManager.GetBlogByCategory(id);
            var categoryName = _blogManager.GetBlogByCategory(id).Select(x => x.Category.CategoryName).FirstOrDefault();
            ViewBag.categoryName = categoryName;
            var categoryDescription = _blogManager.GetBlogByCategory(id).Select(x => x.Category.CategoryDescription).FirstOrDefault();
            ViewBag.categoryDescription = categoryDescription;
            return View(blogListByCategory);
        }

        public ActionResult AdminBlogList()
        {
            var result = _blogManager.GetAll();
            return View(result);
        }
        public ActionResult AdminBlogList2()
        {
            var result = _blogManager.GetAll();
            return View(result);
        }

        [HttpGet]
        public ActionResult AddNewBlog()
        {
            EfContext efContext = new EfContext();
            List<SelectListItem> valuesCategory = (from x in efContext.Categories.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.valuesCategory = valuesCategory;

            List<SelectListItem> valuesAuthor = (from x in efContext.Authors.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.AuthorName,
                                                     Value = x.AuthorId.ToString()
                                                 }).ToList();
            ViewBag.valuesAuthor = valuesAuthor;

            return View();
        }
        [HttpPost]
        public ActionResult AddNewBlog(Blog blog)
        {
            _blogManager.Add(blog);
            return RedirectToAction("AdminBlogList");
        }

        public ActionResult DeleteBlog(int id)
        {
            _blogManager.Delete(id);
            return RedirectToAction("AdminBlogList");
        }
        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            Blog blog = _blogManager.FindBlog(id);
            EfContext efContext = new EfContext();
            List<SelectListItem> valuesCategory = (from x in efContext.Categories.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.valuesCategory = valuesCategory;

            List<SelectListItem> valuesAuthor = (from x in efContext.Authors.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.AuthorName,
                                                     Value = x.AuthorId.ToString()
                                                 }).ToList();
            ViewBag.valuesAuthor = valuesAuthor;
            return View(blog);
        }

        [HttpPost]
        public ActionResult UpdateBlog(Blog blog)
        {
            _blogManager.Update(blog);
            return RedirectToAction("AdminBlogList");
        }

        public ActionResult GetCommentByBlog(int id)
        {
            CommentManager commentManager = new CommentManager(new EfCommentDal());
            var result = commentManager.CommentByBlog(id);
            return View(result);
        }

    }
}