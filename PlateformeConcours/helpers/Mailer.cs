using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
namespace PlateformeConcours.helpers
{
	public enum EmailTemplates
	{
		SIGNUP
	}
	public class Mailer
	{

		/*public static void Send(string to, Hash<String,String> data, EmailTemplates template)
		
			MailMessage mail = new MailMessage();
			SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
			mail.From = new MailAddress("agurram2013@gmail.com");
			mail.To.Add("agurram2013@gmail.com");
			mail.Subject = "Test Mail";
			mail.Body = "This is for testing SMTP mail from GMAIL";
			mail.IsBodyHtml = true;
			SmtpServer.Port = 587;
			SmtpServer.Credentials = new System.Net.NetworkCredential("agurram2013@gmail.com", "Alabasta00*");
			SmtpServer.EnableSsl = false;

			SmtpServer.Send(mail);
	}
	private static string SignUpTemplate(string password)
		{
			return String.Format(@"
<html>
	<head>
		
	</head>
	<body>
		
	</body>
</html>
			");
		}*/
	}
}