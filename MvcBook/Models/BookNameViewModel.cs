using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBook.Models
{
    public class BookNameViewModel
    {
        public List<Book> Books { get; set; }
        public SelectList Names { get; set; }
        public string BookName { get; set; }
        public string SearchString { get; set; }
    }
}
