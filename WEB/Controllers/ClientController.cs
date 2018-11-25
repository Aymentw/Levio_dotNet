using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using WEB.Models;

namespace WEB.Controllers
{
    public class ClientController : Controller
    {
        public ActionResult ListClients()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:18080");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("map-web/map/client/clients").Result;
            if (response.IsSuccessStatusCode)
            {


                ViewBag.result = response.Content.ReadAsAsync<IEnumerable<ClientModel>>().Result;

            }

            else
            {
                ViewBag.result = "error";

            }

            return View();
        }

        [HttpGet]
        public ActionResult createClient()
        {
            return View("createClient");

        }

        [HttpPost]
        public ActionResult createClient(ClientModel c)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:18080");

            client.PostAsJsonAsync<ClientModel>("map-web/map/client", c)
                .ContinueWith((e => e.Result.EnsureSuccessStatusCode()));
            return RedirectToAction("ListClients");
        }

        

    }
}