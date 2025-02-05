using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ticket_System_3_Organic_Tree.Data;
using Ticket_System_3_Organic_Tree.Models;

namespace Ticket_System_3_Organic_Tree.Pages.Knowledge
{
    public class EditModel : PageModel
    {
        private readonly Ticket_System_3_Organic_Tree.Data.ApplicationDbContext _context;

        public EditModel(Ticket_System_3_Organic_Tree.Data.ApplicationDbContext context)
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

            var knownknowledge =  await _context.KnownKnowledge.FirstOrDefaultAsync(m => m.Id == id);
            if (knownknowledge == null)
            {
                return NotFound();
            }
            KnownKnowledge = knownknowledge;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(KnownKnowledge).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KnownKnowledgeExists(KnownKnowledge.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool KnownKnowledgeExists(int id)
        {
            return _context.KnownKnowledge.Any(e => e.Id == id);
        }
    }
}
