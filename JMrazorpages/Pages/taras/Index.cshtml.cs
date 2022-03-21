#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JMrazorpages.Data;

namespace JMrazorpages.Pages.taras
{
    public class IndexModel : PageModel
    {
        private readonly JMrazorpages.Data.JMrazorpagesContext _context;

        public IndexModel(JMrazorpages.Data.JMrazorpagesContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get;set; }

        public async Task OnGetAsync()
        {
            Class = await _context.Class.ToListAsync();
        }
    }
}
