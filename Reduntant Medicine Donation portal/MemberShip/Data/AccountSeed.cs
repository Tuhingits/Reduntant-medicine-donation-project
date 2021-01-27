using Data;
using MemberShip.Context;
using MemberShip.Entities;
using MemberShip.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MemberShip.Data
{
    public class AccountSeed : DataSeed
    {
        private readonly UserManager _userManager;
        private readonly RoleManager _roleManager;

        private readonly ApplicationUser _exicutive, _admin, _donor,_organizar;
        private readonly Role _organizarRole, _adminRole , _donorRole, _executiveRole;

        public AccountSeed(UserManager userManager, RoleManager roleManager, ApplicationDbContext context)
            : base(context)
        {
            _userManager = userManager;
            _roleManager = roleManager;

            _exicutive = new ApplicationUser("superadmin@abc.com", "Sabbir Islam Mukdo", "8801781831484", "bmukdo@gmail.com");
            _admin = new ApplicationUser("admin@admin.com", "Sabbir Islam Mukdo", "8801781831484", "mukdo@gmail.com");
            _donor = new ApplicationUser("donor@gmail.com", "Sabbir Islam Mukdo", "8801781831484", "mukdo@gmail.com");
            _organizar = new ApplicationUser("organizer@gmail.com", "Sabbir Islam Mukdo", "8801781831484", "mukdo@gmail.com");


            _adminRole = new Role("Admin");
            _donorRole = new Role("Donor");
            _organizarRole = new Role("Organization");
            _executiveRole = new Role("Executive");

        }

        private async Task<bool> CheckAndCreateRoleAsync(Role role)
        {
            if ((await _roleManager.FindByNameAsync(role.Name)) == null)
            {
                var result = await _roleManager.CreateAsync(role);
                return result.Succeeded;
            }
            return true;
        }

        private async Task SeedUserAsync()
        {
            IdentityResult result = null;
            if ((await _userManager.FindByNameAsync(_admin.UserName.ToUpper())) == null)
            {
                result = await _userManager.CreateAsync(_admin, "asd123!@#");
                if (result.Succeeded)
                {
                    if (await CheckAndCreateRoleAsync(_adminRole))
                    {
                        await _userManager.AddToRoleAsync(_admin, _adminRole.Name);
                    }
                }
            }

            if ((await _userManager.FindByNameAsync(_donor.UserName.ToUpper())) == null)
            {
                result = await _userManager.CreateAsync(_donor, "Password@2020");
                if (result.Succeeded)
                {
                    if (await CheckAndCreateRoleAsync(_donorRole))
                    {
                        await _userManager.AddToRoleAsync(_donor, _donorRole.Name);
                    }
                }
            }

            if ((await _userManager.FindByNameAsync(_organizar.UserName.ToUpper())) == null)
            {
                result = await _userManager.CreateAsync(_organizar, "Password@2020");
                if (result.Succeeded)
                {
                    if (await CheckAndCreateRoleAsync(_organizarRole))
                    {
                        await _userManager.AddToRoleAsync(_organizar, _organizarRole.Name);
                    }
                }
            }

            if ((await _userManager.FindByNameAsync(_exicutive.UserName.ToUpper())) == null)
            {
                result = await _userManager.CreateAsync(_exicutive, "Password@2020");
                if (result.Succeeded)
                {
                    if (await CheckAndCreateRoleAsync(_executiveRole))
                    {
                        await _userManager.AddToRoleAsync(_exicutive, _executiveRole.Name);
                    }
                }
            }

        }

        public override async Task SeedAsync()
        {
            await SeedUserAsync();
        }

    }
}

