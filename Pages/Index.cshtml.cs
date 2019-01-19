using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CRUDASP.NETMVA.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;

        public IndexModel(AppDbContext db) { _db = db; }

        [BindProperty]
        public IList<Cliente> Clientes { get; private set; }

        public async Task OnGetAsync()
        {
            Clientes = await _db.Clientes.AsNoTracking().ToListAsync();
        }

        public async Task<IActionResult> OnPostExcluirAsync(int id)
        {
            var cliente = await _db.Clientes.FindAsync(id);
            if(cliente != null)
            {
                _db.Clientes.Remove(cliente);
                await _db.SaveChangesAsync();
            }
            return RedirectToPage();
        }
    }
}