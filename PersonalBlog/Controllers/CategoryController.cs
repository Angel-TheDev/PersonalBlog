using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonalBlog.Model;
using PersonalBlog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace PersonalBlog.Controllers
{
    public class CategoryController : Controller
    {
        IRepository<Category> categoryRepo;

        public CategoryController(IRepository<Category> categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

        public ViewResult Index()
        {
            var model = categoryRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = categoryRepo.GetById(id);
            return View(model);
        }

    }
}