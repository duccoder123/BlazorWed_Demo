using AutoMapper;
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
        private readonly IMapper _mapper;
        public CategoryRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public CategoryDTO Create(CategoryDTO categoryDTO)
        {
            var category = _mapper.Map<CategoryDTO, Category>(categoryDTO);
            category.CreatedDate = DateTime.Now;
            var addCateg = _db.Categories.Add(category);
            _db.SaveChanges();
            return _mapper.Map<Category, CategoryDTO>(addCateg.Entity);

        }

        public int Delete(int id)
        {
           var obj = _db.Categories.FirstOrDefault(u=>u.Id== id);
            if (obj != null)
            {
                _db.Categories.Remove(obj);
                return _db.SaveChanges();
            }
            return 0;
        }

        public CategoryDTO Get(int id)
        {
            var obj = _db.Categories.FirstOrDefault(u => u.Id == id);
            if (obj != null)
            {
              return  _mapper.Map<Category,CategoryDTO>(obj); 
            }
            return new CategoryDTO();   
        }

        public IEnumerable<CategoryDTO> GetAll()
        {
           return _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDTO>>(_db.Categories);
        }

        public CategoryDTO Update(CategoryDTO categoryDTO)
        {
           var obj = _db.Categories.FirstOrDefault(u => u.Id == categoryDTO.Id);    
            if (obj != null)
            {
                obj.Name = categoryDTO.Name;
                _db.Categories.Update(obj);
                _db.SaveChanges();
                return _mapper.Map<Category, CategoryDTO>(obj);
            }
            return  categoryDTO;
        }
    }
}
