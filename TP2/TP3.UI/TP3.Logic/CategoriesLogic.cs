using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Data;
using TP3.Entities;

namespace TP3.Logic
{
    public class CategoriesLogic : BaseLogic
    {
        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }

        public void Update(Categories newCategories)
        {
            var CategoriesAModificar = context.Categories.Find(newCategories.CategoryID);
            CategoriesAModificar.Description = "Nueva descripcion";
            context.SaveChanges();
        }

    }
}
