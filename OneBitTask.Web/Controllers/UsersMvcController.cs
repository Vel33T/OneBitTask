namespace OneBitTask.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Data.Repositories;
    using ViewModels;

    public class UsersMvcController : Controller
    {
        private UsersRepository data = new UsersRepository();

        public ActionResult Index()
        {
            var allUsers = this.data.All().Select(UserViewModel.FromUser).ToList();

            return View(allUsers);
        }
    }
}