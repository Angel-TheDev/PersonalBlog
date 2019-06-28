using System;
using PersonalBlog.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonalBlog.Repositories;

namespace PersonalBlog.Repositories
{
    public class CategoryRepository : IRepository<Model.Category>
    {
        private BlogContext db;

        public CategoryRepository(BlogContext db)
        {
            this.db = db;
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return db.Categories.Single(c => c.Id == id);
        }
    }
}
