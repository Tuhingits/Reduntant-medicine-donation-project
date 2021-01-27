using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reduntant_Medicine_Donation_portal.Areas.Donor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reduntant_Medicine_Donation_portal.Areas.Donor.Controllers
{
    [Area("Donor")]
    [Authorize(Roles = "Donor")]
    public class DonorDashBoardController : Controller
    {
        public IActionResult Index()
        {

            var model = new DonorDashBoardModel();
            return View(model);
        }
    }
}
