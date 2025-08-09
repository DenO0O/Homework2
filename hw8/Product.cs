using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8
{
    public enum Category {
        noCategory,
        food,
        homeTechnic
    }

    public class Product
    {
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; } = 0.0M;

        public string PicturePath { get; set; } = string.Empty;

        public Category ProductCategory { get; set; } = Category.noCategory;
    }
}
