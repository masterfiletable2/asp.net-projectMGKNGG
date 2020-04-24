using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.net_projectMGKNGG.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asp.net_projectMGKNGG.Controllers
{
    [Route("api/Order")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _db;

        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data =await _db.Order.ToListAsync() });
        }

        [HttpDelete]

        public async Task<IActionResult> Delete(int id)
        {
            var orderFromDb = await _db.Order.FirstOrDefaultAsync(u => u.Id == id);
            if (orderFromDb == null)
            {
                return Json(new { success = false, message = "Błąd podczas usuwania" });
            }
            _db.Order.Remove(orderFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Usunąłeś zamówienie" });
        }
    }
}