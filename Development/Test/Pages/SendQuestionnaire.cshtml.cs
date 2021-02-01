using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Net.Mail;

namespace Test
{
    public class SendQuestionnaireModel : PageModel
    {
        public void OnGet()
        {

        }

        public void OnPost(int[] questionnaireId)
        {
            var name = Request.Form["Name"];
            var email = Request.Form["Email"];
            ViewData["email"] = $"{email}";
            ViewData["questionnaireId"] = questionnaireId;

            {
                Debug.WriteLine("please work");
                try
                {
                    using (MailMessage mail = new MailMessage())
                    {
                        //email details
                        //who is sending the email
                        mail.From = new MailAddress("AgileGroup9@gmail.com");
                        //who the email is being sent to
                        mail.To.Add(email);
                        //the email subject
                        mail.Subject = "You are being sent questionnaires: " + string.Join(",", (int[])ViewData["questionnaireId"]);
                        //email content
                        mail.Body = "<h1> Questionairres " + string.Join(",", (int[])ViewData["questionnaireId"]) + " </h1>";
                        mail.IsBodyHtml = true;

                        //adds attachment to email
                        //  System.Net.Mail.Attachment attachment;
                        //path to attachment
                        // attachment = new System.Net.Mail.Attachment("path/to/file.file");
                        // mail.Attachments.Add(attachment);

                        //connects to google smtp servers
                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            //user details        
                            //when using google smtp servers you'll have to turn "less secure app access" in security settings
                            smtp.Credentials = new System.Net.NetworkCredential("AgileGroup9@gmail.com", "yellow333!");
                            smtp.EnableSsl = true;
                            smtp.Send(mail);
                            Debug.WriteLine("sent");

                        }

                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }


        }
    }
}