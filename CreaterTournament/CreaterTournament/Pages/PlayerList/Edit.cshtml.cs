using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreaterTournament.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CreaterTournament.Pages.PlayerList
{
    public class EditModel : PageModel
    {
        private ApplicationDBContext _db;

        public EditModel(ApplicationDBContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Player Player { get; set; }

        public async Task OnGet(int id)
        {
            Player = await _db.Player.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var PlayerFromDb = await _db.Player.FindAsync(Player.Id);
                PlayerFromDb.Name = Player.Name;
                PlayerFromDb.Rating = Player.Rating;
                PlayerFromDb.IPIN = Player.IPIN;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
