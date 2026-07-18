
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Count.Pages;

public class IndexModel : PageModel
{
    private static int counter = 0;

    public int Count => counter;

    public void OnGet()
    {
    }

    public IActionResult OnPostAdd()
    {
        counter++;
        return RedirectToPage();
    }

    public IActionResult OnPostReset()
    {
        counter = 0;
        return RedirectToPage();
    }
}