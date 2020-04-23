using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.net_projectMGKNGG.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp.net_projectMGKNGG
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Order Order { get; set; }
        public void OnGet()
        {

        }


        //Tworzenie zamówienia do bazy danych
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Order.AddAsync(Order);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}