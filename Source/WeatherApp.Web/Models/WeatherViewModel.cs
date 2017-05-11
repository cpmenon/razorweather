using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherApp.Services.Models;

namespace WeatherApp.Web.Models
{
    public class WeatherViewModel
    {
        public string Country { get; set; }
        public string Message { get; set; }
        public IEnumerable<SelectListItem> Cities { get; set; }
        public Weather Weather { get; set; }
        public bool Exists { get; set; }
        public string SelectedCity { get; set; }
    }
}