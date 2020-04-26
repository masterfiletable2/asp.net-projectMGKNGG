using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.net_projectMGKNGG.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp.net_projectMGKNGG
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Order Order { get; set; }

        public async Task OnGet(int id)
        {
            Order = await _db.Order.FindAsync(id);
        }

        /* Post handler */

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var OrderFromDb = await _db.Order.FindAsync(Order.Id);
                OrderFromDb.Temat = Order.Temat;
                OrderFromDb.Zleceniodawca = Order.Zleceniodawca;
                OrderFromDb.OpisZamowienia = Order.OpisZamowienia;
                OrderFromDb.Data = Order.Data;

                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
           
              return RedirectToPage();
           
        }
    }
}

