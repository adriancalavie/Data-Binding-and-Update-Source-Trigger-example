using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingAndUpdateSourceTrigger
{
    class CategoryList
    {
        public CategoryList()
        {
            ListOfCategories = new List<string>();

            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                ListOfCategories.Add(category.ToString());
            }
        }

        public List<string> ListOfCategories { get; set; }

    }
}
