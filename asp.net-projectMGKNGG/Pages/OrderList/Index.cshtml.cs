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



        //Usuwanie rekordu
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var order = await _db.Order.FindAsync(id);

            if(order == null)
            {
                return NotFound();
            }
            _db.Order.Remove(order);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}