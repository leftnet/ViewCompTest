using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViewCompTest.ViewComponents;

namespace ViewCompTest.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

        public ActionResult OnGetViewComponent(int count)
        {
            return ViewComponent(nameof(TestComponent), new { count });
        }
    }
}