using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcBlog.Models
{
    public class Comments
    {
        public int Id { get; set; }
        [Display(Name = "Идентификатор записи")]
        public int PostID { get; set; }  

        [Display(Name = "Автор комментария")]
        public string Author { get; set; }

        [Display(Name = "Текст комментария")]
        public string Message { get; set; }

        [DataType(DataType.Date)]

        [Display(Name = "Дата создания")]
        public DateTime CreationDate { get; set; }
    }
}
