using BlazorDemo_Business.Repository.IRepository;
using BlazorDemo_DataAccess;
using BlazorDemo_DataAccess.Data;
using BlazorDemo_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemo_Business.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public CategoryDTO Create(CategoryDTO categoryDTO)
        {
            Category category = new Category()
            {
                Id = categoryDTO.Id,
                Name = categoryDTO.Name,
                CreatedDate = DateTime.Now
            };
            _db.Categories.Add(category);
            _db.SaveChanges();
            return new CategoryDTO
            {
                Id = categoryDTO.Id,
                Name = categoryDTO.Name
            };

        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CategoryDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public CategoryDTO Update(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }
    }
}
