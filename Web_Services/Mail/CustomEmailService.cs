using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Web_Services.ApiMapping;

namespace Web_Services.Mail 
{
       

    public class CustomEmailService
    {
        public MailAddress to { get; set; }
        public MailMessage mail { get; set; }
        public string sub { get; set; }
        public string body { get; set; }
        private string _emailAddress { get; set; }
        private string _emailPassword { get; set; }
        private  string LocalUrl { get; set; }

        //Constructor
        public CustomEmailService()
        {
            mail = new MailMessage(); 
            //Get Email from Web.config
            mail.From = new MailAddress(ConfigurationManager.AppSettings["EmailAddress"]);
            mail.Subject =  "Donation To Schools";
            mail.Body="Thank you for your purchase, all of the money will be given to selected schools in order to help upgrade the current facilities.";

            _emailAddress = ConfigurationManager.AppSettings["EmailAddress"];//Get Email from Web.config
            _emailPassword = ConfigurationManager.AppSettings["EmailPassword"];//Get Pass from Web.config

            LocalUrl = System.Web.HttpContext.Current.Server.MapPath("~/images/paintings/");//Get current url of painting folder

        }


        public void CreateAttachments(List<string> paintingIDs)
        {
            PaintingApiService ServicePainting = new PaintingApiService();


            //Purpose of LINQ: Get list of paintings and a list of selected painting ids and fill the list of mail.Attachments
            

            ServicePainting                                 //Service For Paintings
                .GetPaintings()                             //Will Get A List of Paintings From API
                .Where(a => paintingIDs                     //From paintingIDs
                    .Select(int.Parse)                      //Convert Everything To INT
                    .ToList()                               //Convert To List
                    .Contains(a.PaintingId))                //Filter Resault With The Paintings id From API
                .Select(b => b.ImageUrl)                    //Keep Only The Img Source
                .Select(c => new Attachment(LocalUrl+c))    //Create Attachment With Local URL For Every Img Scource in List
                .ToList()                                   //Convert To List, Nessesary To Add a ForEach Later
                .ForEach(d => { mail.Attachments.Add(d);}); //Add Each Attachment Created Above, Into the List Of Attachments in mail 
                                                            //LINQ returns Null...so no need to save a var
        }

       
        public void SendMail()
        {
            //to: Recievers Email
            mail.To.Add(to); 
            mail.Sender = to;

            SmtpClient smtp = new SmtpClient
            {
                //Outlook Mail Server
                Host = "pod51014.outlook.com",
                Port = 587,
                Credentials = new NetworkCredential(_emailAddress, _emailPassword),
                EnableSsl = true
            };

            smtp.Send(mail);
        }
    }
}
