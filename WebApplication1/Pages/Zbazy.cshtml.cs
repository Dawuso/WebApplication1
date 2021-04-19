using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class ZbazyModel : PageModel
    {
        private readonly WebApplication1.Data.ProductContext _context;

        public ZbazyModel(WebApplication1.Data.ProductContext context)
        {
            _context = context;
        }

        public IList<Product> Products { get; set; }

        public void OnGet()
        {
            Products = _context.Product.ToList();
        }
    }
}
