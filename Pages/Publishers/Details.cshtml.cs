﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Luca_Andra_Lab2._2.Data;
using Luca_Andra_Lab2._2.Models;

namespace Luca_Andra_Lab2._2.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Luca_Andra_Lab2._2.Data.Luca_Andra_Lab2_2Context _context;

        public DetailsModel(Luca_Andra_Lab2._2.Data.Luca_Andra_Lab2_2Context context)
        {
            _context = context;
        }

      public Publisher Publisher { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Publisher == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else 
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
