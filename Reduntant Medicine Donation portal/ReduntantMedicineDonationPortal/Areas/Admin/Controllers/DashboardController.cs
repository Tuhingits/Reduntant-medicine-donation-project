using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Reduntant_Medicine_Donation_portal.Areas.Admin.Models;

namespace Reduntant_Medicine_Donation_portal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
       
        public IActionResult Index()
        {
            
            var model = new DashBoardModel();
            return View(model);

        } 
    }
}