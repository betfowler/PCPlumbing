using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Net;
using reCAPTCHA.MVC;
using Newtonsoft.Json;
using PCPlumbing.Models;

namespace PCPlumbing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Contact(string success)
        {
            if(success != null)
            {
                ViewBag.Success = success;
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact([Bind(Include = "customerName,emailAddress,contactNumber,message")] Contact contact)
        {
                if (ModelState.IsValid)
                {
                    string EncodedResponse = Request.Form["g-Recaptcha-Response"];
                    bool IsCaptchaValid = (ReCaptcha.Validate(EncodedResponse) == "True" ? true : false);
                    if (IsCaptchaValid)
                    {
                        //send email
                        var body = "<p>Name: {0}</p><p>Email address: {1}</p><p>Contact number: {2}</p><p>Message: {3}</p>";
                        string messageBody = string.Format(body, contact.customerName.ToString(), contact.emailAddress.ToString(), contact.contactNumber.ToString(), contact.message.ToString());
                        string to = "bethany.fowler14@gmail.com";
                        string from = "pcplumbingsomerset@gmail.com";
                        string subject = "PC Plumbing Online Enquiry";

                        await SendMessage(to, from, messageBody, subject);

                        return RedirectToAction("Contact", new { success = "Your message has been sent to PC Plumbing"});
                    }
                    else
                    {
                        TempData["recaptcha"] = "Please verify that you are not a robot";
                    }                    
                }

            return View(contact);
        }

        public async Task<ActionResult> SendMessage(string to, string from, string body, string subject)
        {
            //send email
            var message = new MailMessage();
            message.Body = body;
            message.To.Add(new MailAddress(to));
            message.From = new MailAddress(from);
            message.Subject = subject;
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "pcplumbingsomerset@gmail.com",
                    Password = "gnibmulP1"
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;

                await smtp.SendMailAsync(message);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ContactForm()
        {
            
            return View();
        }
        

        public ActionResult Plumbing()
        {
            return View();
        }

        public ActionResult CentralHeating()
        {
            return View();
        }
        
        public ActionResult Boilers()
        {
            return View();
        }
        public ActionResult Bathrooms()
        {
            return View();
        }
        public ActionResult Renewable()
        {
            return View();
        }
        public ActionResult Advice()
        {
            return View();
        }
    }
}