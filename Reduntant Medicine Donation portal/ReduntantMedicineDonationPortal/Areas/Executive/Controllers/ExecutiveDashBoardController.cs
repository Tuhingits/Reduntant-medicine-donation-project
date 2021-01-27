using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reduntant_Medicine_Donation_portal.Areas.Executive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reduntant_Medicine_Donation_portal.Areas.Executive.Controllers
{
    public class ExecutiveDashBoardController : Controller
    {
        [Area("Executive")]
        [Authorize(Roles = "Executive")]
        public IActionResult Index()
        {
            var model = new ExecutiveDashBoardModel();
            return View(model);
        }
    }
}
