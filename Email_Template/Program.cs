﻿using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace SendEmailWithSTMP
{
    class Program2
    {
        static void Main(string[] args)
        {
            Program2 a = new Program2();
            //a.send_email_thay_doi_email_khach_san_thanh_cong();
            a.send_email_xung_dot_cap_nhat_thong_tin_blocking();
        }
        public void send_email_thay_doi_email_khach_san_thanh_cong()
        {
            string x = "<h1>hehehe</h1>";

            FileStream fs = new FileStream("C:\\Users\\ACER\\Desktop\\Email_Template\\Email_Template\\thay_doi_email_khach_san_thanh_cong.html", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            String str = rd.ReadToEnd();
            MailMessage message = new MailMessage("namnguyenthanh2k1@gmail.com", "namnguyenthanh2k1@gmail.com", "Subject", str);

            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = Regex.IsMatch(x, @"<\s*([^ >]+)[^>]*>.*?<\s*/\s*\1\s*>");
            message.ReplyToList.Add(new MailAddress("namnguyenthanh2k1@gmail.com"));
            message.Sender = new MailAddress("namnguyenthanh2k1@gmail.com");

            using var smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("namnguyenthanh2k1@gmail.com", "Flatrone1940s*");
            try
            {
                smtpClient.Send(message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void send_email_xung_dot_cap_nhat_thong_tin_blocking()
        {
            string x = "<h1>hehehe</h1>";

            FileStream fs = new FileStream("C:\\Users\\ACER\\Desktop\\Email_Template\\Email_Template\\xung_dot_cap_nhat_thong_tin_blocking.html", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            String str = rd.ReadToEnd();
            MailMessage message = new MailMessage("namnguyenthanh2k1@gmail.com", "namnguyenthanh2k1@gmail.com", "Subject", str);

            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = Regex.IsMatch(x, @"<\s*([^ >]+)[^>]*>.*?<\s*/\s*\1\s*>");
            message.ReplyToList.Add(new MailAddress("namnguyenthanh2k1@gmail.com"));
            message.Sender = new MailAddress("namnguyenthanh2k1@gmail.com");

            using var smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("namnguyenthanh2k1@gmail.com", "Flatrone1940s*");
            try
            {
                smtpClient.Send(message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
