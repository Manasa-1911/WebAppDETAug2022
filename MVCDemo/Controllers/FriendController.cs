using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Services;

namespace MVCDemo.Controllers
{
    public class FriendController : Controller
    {
        public IActionResult Index()
        {
            List<Friend> friends = FriendService.GetAll();
            return View(friends);
        }

        public IActionResult List()
        {
            List<Friend> friends = FriendService.GetAll();
            return View(friends);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Friend p)
        {
            FriendService.Add(p);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            Friend f = FriendService.Get(id);
            if (f != null)
                return View(f);
            else
                return RedirectToAction("List");
        }


        [HttpPost]
        public IActionResult Delete(Friend f)
        {

            //Friend f = FriendService.Get(f.Fr);
            FriendService.Delete(f.id);
            return RedirectToAction("List");
        }


        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(Friend f)
        {
            FriendService.Update(f);
            return RedirectToAction("List");
        }


    }
}
