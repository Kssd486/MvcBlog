using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int CategoryID { get; set; }

        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        [Display(Name = "Дата создания")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Автор")]
        public string Author { get; set; }

        [Display(Name = "Текст")]
        public string Text { get; set; }

        
    }
}
