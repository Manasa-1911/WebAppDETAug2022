using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Services;

namespace WebAppDETAug2022.Pages
{
    public class HeloPageModel : PageModel
    {
        public IHelo ob { get; set; }

        public string Message { get; set; }

        public HeloPageModel(IHelo i)
        {
            ob = i;
        }
        public void OnGet()
        {
            Message = ob.SayHelo("Manasa");
        }
    }
}
