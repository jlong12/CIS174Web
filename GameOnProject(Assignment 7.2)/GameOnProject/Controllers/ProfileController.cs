using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using GameOnProject.Shared.Orchestrators;
using GameOnProject.Shared.Orchestrators.Interfaces;
using GameOnProject.Shared.ViewModels;
using GameOnProject.Web.Models;

namespace GameOnProject.Controllers
{
    public class ProfileController : Controller
    {
        //private readonly IProfileOrchestrator _profileOrchestrator;

        private ProfileOrchestrator _profileOrchestrator = new ProfileOrchestrator();

        /*public ProfileController(IProfileOrchestrator profileOrchestrator)
        {
            _profileOrchestrator = profileOrchestrator;
       } */

        //private PersonOrchestrator _personOrchestrator = new PersonOrchestrator();

        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Update()
        {
            //var id = Session["UserEmail"].ToString();

            // TODO: Call the method on the orchestrator that gets the person by email

            // Return with the viewmodel if person is found
            //return View(viewModel);

            var email = Session["Email"];
            var viewModel = _profileOrchestrator.GetProfileByEmail(email.ToString());
            return View(viewModel);

            // Return without the viewmodel if no person is found
            return View();

            //Guid.TryParse(id, out var newGuid);

            //if (newGuid != null)
            //{
            //    var viewModel = _profileOrchestrator.SearchPerson(newGuid.ToString());
            //    return View(viewModel);
            //}

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

        /*

        public async Task<JsonResult> Search(string searchString)
        {
            var id = Session["userId"].ToString();
            Guid newGuid = Guid.Parse(id);

            if (searchString.Equals(newGuid))
            {
                var viewModel = await _profileOrchestrator.SearchPerson(id);
                return Json(viewModel, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var viewModel = await _profileOrchestrator.SearchPerson(searchString);

                return Json(viewModel, JsonRequestBehavior.AllowGet);
            }
            
        }*/
    }
}
 