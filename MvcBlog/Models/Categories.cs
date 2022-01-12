using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcBlog.Models
{
    public class Categories
    {
        public int Id { get; set; }

        [Display(Name = "Наименование категории записи")]
        public string Name { get; set; }

    }
}
