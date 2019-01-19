using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDASP.NETMVA.Pages
{
    public class CadastroModel : PageModel
    {
        private readonly AppDbContext _db;

        public CadastroModel(AppDbContext db) { _db = db; }

        [BindProperty]
        public Cliente Cliente { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) { return Page(); }

            _db.Clientes.Add(Cliente);
            await _db.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}