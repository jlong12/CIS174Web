using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using GameOnProject.Shared.Orchestrators;
using GameOnProject.Shared.ViewModels;
using GameOnProject.Web.Models;

namespace GameOnProject.Controllers
{
    public class ProfileController : Controller
    {
        private ProfileOrchestrator _profileOrchestrator = new ProfileOrchestrator();

        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

        public async Task<JsonResult> UpdateProfile(ProfileModel profile)
        {
            if (profile.UserId == Guid.Empty)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

            var result = await _profileOrchestrator.UpdateProfile(new ProfileViewModel
            {
                UserId = profile.UserId,
                FirstName = profile.FirstName,
                LastName = profile.LastName,
                Gender = profile.Gender,
                Email = profile.Email,
                PhoneNumber = profile.PhoneNumber
            });

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}