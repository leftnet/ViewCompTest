using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ViewCompTest.ViewComponents;

public class TestComponent : ViewComponent
{
    public IViewComponentResult Invoke(int count)
    {
        var vm = new List<SelectListItem>();
        for (var i = 0; i < count; i++)
        {
            var x = Guid.NewGuid().ToString();
            vm.Add(new SelectListItem {Value = x, Text = x});
        }

        return View(vm);
    }
}