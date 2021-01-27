using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reduntant_Medicine_Donation_portal.Areas.Organizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reduntant_Medicine_Donation_portal.Areas.Organizer.Controllers
{
    [Area("Organizer")]
    [Authorize(Roles = "Organizer")]
    public class OrganizerDashBoardController : Controller
    {
        public IActionResult Index()
        {
            var model = new OrganizerDashBoardModel();
            return View(model);
        }
    }
}
