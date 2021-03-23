using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreaterTournament.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CreaterTournament.Pages.PlayerList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        public IndexModel(ApplicationDBContext db)
        {
            _db = db;
        }

        public IEnumerable<Player> Players { get; set; }

        public async Task OnGet()
        {
            Players = await _db.Player.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var player = await _db.Player.FindAsync(id);
            if (player == null)
            {
                return NotFound();
            }
            _db.Player.Remove(player);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
