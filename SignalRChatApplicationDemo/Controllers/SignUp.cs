using Microsoft.AspNetCore.Mvc;
using static SignalRChatApplicationDemo.Models.SignUp;


namespace SignalRChatApplicationDemo.Controllers
{
    public class SignUp : Controller
    {
       // ChatApplicationEntities1 db = new ChatApplicationEntities1();
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(Tbl_Users user)
        //{
        //  //  db.Tbl_Users.Add(user);
        //   // db.SaveChanges();
        //    return View();
        //}
    }
}
