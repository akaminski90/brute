using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BruteApp.Helpers;
using BruteApp.Models;
using umbraco.uicontrols;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace BruteApp.Controllers
{
    public class FeedbackController : SurfaceController
    {
        [HttpPost]
        public ActionResult Send (FeedbackModel feedback)
        {
            TempData["IsActiveContactForm"] = true;
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            var umbracoHelper = new UmbracoHelper(UmbracoContext.Current);
            const string title = "Новое сообщение";
            var mailBodyTemplate = ResourceHelper.Get("Feedback.txt");
            var mailBody = string.Format(mailBodyTemplate,
                title,
                feedback.Name,
                feedback.Email,
                feedback.File
            );
            EmailHelper.SendEmail(ConfigurationManager.AppSettings["workEmail"], mailBody, "Новый перевод");
            TempData["MailSent"] = "Перевод успешно отправлен";
            return RedirectToCurrentUmbracoPage();
        }
    }
}