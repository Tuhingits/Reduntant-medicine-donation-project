using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Framework;
using Reduntant_Medicine_Donation_portal.Areas.Common;

namespace Reduntant_Medicine_Donation_portal.Areas.Admin.Models
{
    public abstract class AdminBaseModel
    {
        public MenuModel MenuModel { get; set; }
        public ResponseModel Response
        {
            get
            {
                if (_httpContextAccessor.HttpContext.Session.IsAvailable
                    && _httpContextAccessor.HttpContext.Session.Keys.Contains(nameof(Response)))
                {
                    var response = _httpContextAccessor.HttpContext.Session.Get<ResponseModel>(nameof(Response));
                    _httpContextAccessor.HttpContext.Session.Remove(nameof(Response));

                    return response;
                }
                else
                    return null;
            }
            set
            {
                _httpContextAccessor.HttpContext.Session.Set(nameof(Response),
                    value);
            }
        }

        protected IHttpContextAccessor _httpContextAccessor;
        public AdminBaseModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            SetupMenu();
        }

        public AdminBaseModel()
        {
            _httpContextAccessor = Startup.AutofacContainer.Resolve<IHttpContextAccessor>();
            SetupMenu();
        }

        private void SetupMenu()
        {
            MenuModel = new MenuModel
            {
                MenuItems = new List<MenuItem>
                {
                    new MenuItem
                    {
                        Title = "Register Admin",
                        Url ="#"
                    },
                    new MenuItem
                    {
                        Title = "Transaction",
                        Url="#"

                    },
                    new MenuItem
                    {
                        Title = "Manage Members",
                        Url = "#"
                    },
                    new MenuItem
                    {
                        Title = "FeedBacks",
                        Url = "#"
                    }
                }
            };

        }
    }
}

