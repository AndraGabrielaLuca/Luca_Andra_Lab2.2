using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Luca_Andra_Lab2._2.Data;
using Luca_Andra_Lab2._2.Models;
using Luca_Andra_Lab2._2.ViewModles;

namespace Luca_Andra_Lab2._2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Luca_Andra_Lab2._2.Data.Luca_Andra_Lab2_2Context _context;

        public IndexModel(Luca_Andra_Lab2._2.Data.Luca_Andra_Lab2_2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;
        public PublisherIndexData PublisherData { get; set; }
        public int PublisherID { get; set; }
        public int BookID { get; set; }
        public async Task OnGetAsync(int? id, int? bookID)
        {
            if (_context.Publisher != null)
            {
                PublisherData = new PublisherIndexData();
                PublisherData.Publishers = await _context.Publisher
                .Include(i => i.Books)
                .ThenInclude(c => c.Author)
                .OrderBy(i => i.PublisherName)
                .ToListAsync();
                if (id != null)
                {
                    PublisherID = id.Value;
                    Publisher publisher = PublisherData.Publishers
                    .Where(i => i.ID == id.Value).Single();
                    PublisherData.Books = publisher.Books;
                }
            }
        }
    }
}
