using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BmiAplikace.Models;

namespace BmiAplikace.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public required BmiModel BmiData { get; set; }
        public bool ZobrazeniVysledku { get; set; } = false;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                BmiData.SpocitejBmi();
                ZobrazeniVysledku = true;
                return Page();
            }
            return Page();
        }
    }
}