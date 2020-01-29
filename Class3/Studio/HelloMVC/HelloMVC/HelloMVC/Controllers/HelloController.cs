using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{

    public class HelloController : Controller
    {
        // GET: /<controller>/

        [HttpGet]   
        public IActionResult Index()
        {
            string hi = "<form method='post' action='/Hello/Display'>"
                + "<input type ='text' name='fname' style='font-weight:bold' />"
                + "<select name='language' style='font-weight:bold' </select>"
                + "<option value = '' ></option>"
                + "<option value = 'english'>English </option>"
                + "<option value = 'spanish'>Spanish</option>"
                + "<option value = 'hindi'>Hindi</option>"
                + "<option value = 'french'>French</option>"
                + " <option value = 'german'>German</option>"
                + "<input type='submit' style='font-weight:bold' value='Greet me!' />"
                + "</form>";
            return Content(hi, "text/html");
        }

        //Route("/Hello")]
        [HttpPost, HttpGet]
        public IActionResult Display(string fname, string language)
        {
            int count = 1;
            foreach (KeyValuePair<String, String> cook in Request.Cookies)
            {
                if (cook.Key == "count")
                {
                    count = Convert.ToInt32(cook.Value);
                    count++;
                }
            }
            string greetMe = CreateMessage(fname, language);
            Response.Cookies.Append("count", "" + count);

            return Content("<p style='font-size:100px ; font-family:Comic Sans MS; color:teal; font-weight:bold'>" + greetMe + " ! <img src='https://i.pinimg.com/originals/26/f6/ba/26f6ba75a1a5a182ce82562f3c6a93a0.jpg' width='125' height='125'>" + " </p>" + "count:" + count, "text/html");
        }

        public static string CreateMessage(string fname, string language)
        {

            Dictionary<string, string> welcomeMessage = new Dictionary<string, string>()
            {
                {"english", "Hello"},
                {"spanish", "Hola"},
                {"hindi", "Namaste"},
                {"french", "Bonjour"},
                {"german", "Hallo"}
            };
            string msg = "";
            foreach (KeyValuePair<string, string> greeting in welcomeMessage)
            {
                if (greeting.Key == language)
                {
                    msg = greeting.Value;
                }
            }
            return msg + " " + fname;
        }
    }
}
