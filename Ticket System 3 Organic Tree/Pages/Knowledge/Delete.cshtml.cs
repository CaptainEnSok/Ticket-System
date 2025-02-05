using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ticket_System_3_Organic_Tree.Data;
using Ticket_System_3_Organic_Tree.Models;

namespace Ticket_System_3_Organic_Tree.Pages.Knowledge
{
    public class DeleteModel : PageModel
    {
        private readonly Ticket_System_3_Organic_Tree.Data.ApplicationDbContext _context;

        public DeleteModel(Ticket_System_3_Organic_Tree.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public KnownKnowledge KnownKnowledge { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knownknowledge = await _context.KnownKnowledge.FirstOrDefaultAsync(m => m.Id == id);

            if (knownknowledge == null)
            {
                return NotFound();
            }
            else
            {
                KnownKnowledge = knownknowledge;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knownknowledge = await _context.KnownKnowledge.FindAsync(id);
            if (knownknowledge != null)
            {
                KnownKnowledge = knownknowledge;
                _context.KnownKnowledge.Remove(KnownKnowledge);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
