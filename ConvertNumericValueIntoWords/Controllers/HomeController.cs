using ConvertNumericValueIntoWords.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ConvertNumericValueIntoWords.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult NumberConvertor()
        {
            return View();
        }
        public ActionResult ConvertNumber(NumberConvertorVM numberConvertor)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    string baseUrl = Path.Combine(string.Format("{0}://{1}{2}", Request.Url.Scheme, Request.Url.Authority, Url.Content("~")), "api/");
                    client.BaseAddress = new Uri(baseUrl);
                    //HTTP GET
                    var responseTask = client.GetAsync("NumberConverterApi/NumberConvertIntoWord?number=" + Convert.ToString(numberConvertor.Number));
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<string>();
                        readTask.Wait();

                        numberConvertor.NumberInWord = readTask.Result;
                    }
                }
                return View(numberConvertor);
            }
            return View("NumberConvertor", numberConvertor);
        }
    }
}