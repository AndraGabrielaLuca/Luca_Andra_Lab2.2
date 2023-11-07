using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Luca_Andra_Lab2._2.Data;
using Luca_Andra_Lab2._2.Models;

namespace Luca_Andra_Lab2._2.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly Luca_Andra_Lab2._2.Data.Luca_Andra_Lab2_2Context _context;

        public IndexModel(Luca_Andra_Lab2._2.Data.Luca_Andra_Lab2_2Context context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Member != null)
            {
                Member = await _context.Member.ToListAsync();
            }
        }
    }
}
