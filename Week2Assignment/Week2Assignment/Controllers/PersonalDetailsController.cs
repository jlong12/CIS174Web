using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week2Assignment.Models;
using Week2Assignment.shared.Enums;
using Week2Assignment.shared.Orchestrators;

namespace Week2Assignment.Controllers
{
    public class PersonalDetailsController : Controller
    {
        // GET: PersonalDetails
        public ActionResult Index()
        {
            var personalDetailsOrchestrator = new PersonalDetailsOrchestrator();

            var personalDetailsModel = new PersonalDetailsModel
            {
                PersonalDetails = personalDetailsOrchestrator.GetPersonalDetails(),
                firstName = "Jonathan",
                lastName = "Long",
                age = 24,
                major = "BIS Web Development",
                Gender = GenderEnum.Male,
            };

            return View(personalDetailsModel);
        }
    }
}