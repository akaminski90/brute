using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BruteApp.Models
{
    public class FeedbackModel
    {
        [Required(ErrorMessage = "Введите Ваше имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введите ссылку на профиль ВК, Фейсбук или Инстаграм")]
        public string Link { get; set; }
        [Required(ErrorMessage = "Введите Ваш e-mail")]
        [EmailAddress(ErrorMessage = "Проверьте правильность введенного адреса электронной почты")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Прикрепите текстовый файл с переводом песни")]
        public HttpPostedFileBase File { get; set; }
    }
}