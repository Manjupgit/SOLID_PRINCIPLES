using LSP.Core;
using LSP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LSP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<ISettings> settings = new List<ISettings>();

        List<IReadableSettings> readableSettings = new List<IReadableSettings>();
        List<IWritableSettings> writableSettings = new List<IWritableSettings>();


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
            GlobalSettings g = new GlobalSettings();
            //SectionSettings s = new SectionSettings("Sports");
            //UserSettings u = new UserSettings("User1");
            GuestSettings gu = new GuestSettings();
            /*
            settings.Add(g);
            //settings.Add(s);
            //settings.Add(u);
            settings.Add(gu);
            */
            readableSettings.Add(g);
            //readableSettings.Add(s);
            //readableSettings.Add(u);
            readableSettings.Add(gu);

            writableSettings.Add(g);
            //writableSettings.Add(s);
            //writableSettings.Add(u);
        }

        public IActionResult Index()
        {
            // var allSettings = SettingsHelper.GetAllSettings(settings);
            //With LSP
            var allSettings = SettingsHelper.GetAllSettings(readableSettings);

            return View(allSettings);
        }

        //Click on Change Settings button
        public IActionResult Save()
        {
            List<Dictionary<string, string>> newSettings = new List<Dictionary<string, string>>();

            Dictionary<string, string> app = new Dictionary<string, string>();
            app.Add("Theme", "Winter");

            Dictionary<string, string> sec = new Dictionary<string, string>();
            sec.Add("Title", "Music");

            Dictionary<string, string> usr = new Dictionary<string, string>();
            usr.Add("DisplayName", "Tom");

            Dictionary<string, string> gst = new Dictionary<string, string>();
            gst.Add("GuestName", "Jerry");

            newSettings.Add(app);
            newSettings.Add(sec);
            newSettings.Add(usr);
            newSettings.Add(gst);

           //Without LSP
           //List<string> model = SettingsHelper.SetAllSettings(settings, newSettings);
            List<string> model = SettingsHelper.SetAllSettings(writableSettings, newSettings);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
