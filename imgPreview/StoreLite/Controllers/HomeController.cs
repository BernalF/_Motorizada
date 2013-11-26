using System.Linq;
using StoreLite.Models;
using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

namespace StoreLite.Controllers
{
    /// <summary>
    /// Home Controller class
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Articles Index VIew
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var serverRootPath = Server.MapPath("~");
            var files = Path.Combine(serverRootPath, "Images");         
            var images = Directory.GetFiles(files);            
            ImageModel imgs = new ImageModel();
            foreach (var i in images)
            {
                var fn = Path.GetFileName(i);
                imgs.Images.Add("/StoreLite/Images/{x}/" + fn);                
            }
            return View(imgs);
        }
    }
}
