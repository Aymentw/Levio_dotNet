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

    public class RequestController : Controller
    {
        public ActionResult Index() 
        {
            IEnumerable<RequestModel> requestList;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:18080/map-web/map/User/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("getAllRequests").Result;
            try
            {
                requestList = response.Content.ReadAsAsync<IEnumerable<RequestModel>>().Result;

            }
            catch (AggregateException e)
            {

                Console.WriteLine(e);
                throw;
            }
         
            return View(requestList);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:18080/map-web/map/client/");
            HttpResponseMessage response = client.GetAsync("DeleteRequest?id=" + id).Result;
            return RedirectToAction("Index");

        }
        [HttpPost]
        public ActionResult DeleteTreatedRequests()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:18080/map-web/map/User/");
            HttpResponseMessage response = client.GetAsync("deleteTreatedRequets").Result;
            return RedirectToAction("Index");

        }

          [HttpPost]
        public ActionResult TreatRequest(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:18080/map-web/map/User/");
            HttpResponseMessage response = client.GetAsync("treatClientRequest?requestId="+id).Result;
            return RedirectToAction("Index");

        }
    }
}