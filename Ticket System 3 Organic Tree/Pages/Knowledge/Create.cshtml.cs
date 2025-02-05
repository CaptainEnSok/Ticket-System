using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ticket_System_3_Organic_Tree.Data;
using Ticket_System_3_Organic_Tree.Models;

namespace Ticket_System_3_Organic_Tree.Pages.Knowledge
{
    public class CreateModel : PageModel
    {
        private readonly Ticket_System_3_Organic_Tree.Data.ApplicationDbContext _context;

        public CreateModel(Ticket_System_3_Organic_Tree.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public KnownKnowledge KnownKnowledge { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.KnownKnowledge.Add(KnownKnowledge);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
