﻿using BackendProject.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using MailKit.Net.Smtp;
using MailKit.Security;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Services
{
    public class EmailService : IEmailService
    {

        private readonly IConfiguration Configuration;

        public EmailService(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void Send(string to, string subject, string body, string from = null)
        {
            // create message
            var email = new MimeMessage();

            email.From.Add(MailboxAddress.Parse(from ?? Configuration.GetSection("Smtp:FromAddress").Value));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = body };

            // send email
            using var smtp = new SmtpClient();
            smtp.Connect(Configuration.GetSection("Smtp:Server").Value, int.Parse(Configuration.GetSection("Smtp:Port").Value), SecureSocketOptions.StartTls);
            smtp.Authenticate(Configuration.GetSection("Smtp:FromAddress").Value, Configuration.GetSection("Smtp:Password").Value);
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
