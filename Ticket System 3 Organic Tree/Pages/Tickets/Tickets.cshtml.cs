using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Ticket_System_3_Organic_Tree.Data;
using Ticket_System_3_Organic_Tree.Models;

namespace Ticket_System_3_Organic_Tree.Pages.Tickets
{
    public class TicketsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public TicketsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Ticket> Ticket { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Ticket = await _context.Ticket.ToListAsync();
        }
    }
}