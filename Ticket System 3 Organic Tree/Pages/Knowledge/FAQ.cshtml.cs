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
    public class FAQModel : PageModel
    {
        private readonly Ticket_System_3_Organic_Tree.Data.ApplicationDbContext _context;

        public FAQModel(Ticket_System_3_Organic_Tree.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<KnownKnowledge> KnownKnowledge { get;set; } = default!;

        public async Task OnGetAsync()
        {
            KnownKnowledge = await _context.KnownKnowledge.ToListAsync();
        }
    }
}
