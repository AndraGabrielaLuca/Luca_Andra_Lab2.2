﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Luca_Andra_Lab2._2.Data;
using Luca_Andra_Lab2._2.Models;

namespace Luca_Andra_Lab2._2.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Luca_Andra_Lab2._2.Data.Luca_Andra_Lab2_2Context _context;

        public DetailsModel(Luca_Andra_Lab2._2.Data.Luca_Andra_Lab2_2Context context)
        {
            _context = context;
        }

      public Category Category { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}