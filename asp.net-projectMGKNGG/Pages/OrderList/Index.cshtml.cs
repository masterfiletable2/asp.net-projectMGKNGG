using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.net_projectMGKNGG.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace asp.net_projectMGKNGG
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }


        public IEnumerable<Order> Orders { get; set; }
        
        //pobieranie danych z zamowieniami wewnatrz IEnumerable z uzyciem async
        public async Task OnGet()
        {
            Orders = await _db.Order.ToListAsync();
        }
    }
}