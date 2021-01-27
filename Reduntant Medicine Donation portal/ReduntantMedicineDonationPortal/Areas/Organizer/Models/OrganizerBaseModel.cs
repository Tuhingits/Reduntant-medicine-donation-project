using Autofac;
using Framework;
using Microsoft.AspNetCore.Http;
using Reduntant_Medicine_Donation_portal.Areas.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reduntant_Medicine_Donation_portal.Areas.Organizer.Models
{
    public abstract class OrganizerBaseModel
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
        public OrganizerBaseModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            SetupMenu();
        }

        public OrganizerBaseModel()
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
                        Title = "View Comment",
                        Url = "#"
                    },
                    new MenuItem
                    {
                        Title = "Category",
                        Url = "#"
                    },
                    new MenuItem
                    {
                        Title = "Blog Compose",
                        Url = "#"
                    },

                    new MenuItem
                    {
                        Title = "Setting",
                        Url = "#"
                    }
                }
            };

        }
    }
}
