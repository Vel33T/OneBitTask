namespace OneBitTask.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Data.Repositories;
    using ViewModels;
    using Models;

    public class UsersMvcController : Controller
    {
        private IRepository<User> data;

        public UsersMvcController(IRepository<User> data)
        {
            this.data = data;
        }

        public ActionResult Index()
        {
            var allUsers = this.data.All().Select(UserViewModel.FromUser).ToList();

            return View(allUsers);
        }
    }
}