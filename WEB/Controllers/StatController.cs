using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace WEB.Controllers
{
    public class StatController : Controller
    {
        // GET: Stat
        public ActionResult Index()
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:18080");
            Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = Client.GetAsync("map-web/map/dashboard/skills").Result;
            if(response.IsSuccessStatusCode)
            {
                ViewBag.result = response.Content.ReadAsAsync<List<Object>>().Result;
            }
            else
            {
                ViewBag.result = "error";
            }

            return View();
        }
        [HttpGet]
        public ActionResult getReport(int resourceId)
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:18080");
            Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = Client.GetAsync("map-web/map/dashboard/report/"+resourceId).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("le rapport est prêt");
            }
            else
            {
                ViewBag.result = "error";
            }
            return RedirectToAction("Index");
        }
    }
}