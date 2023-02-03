using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using SupportDashAI.Domain.Repositories;
using Microsoft.Extensions.Logging;

namespace SupportDashAI.Domain.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly IFeatureSettingRepository featureSettingRepository;
        private readonly ILogger<EmailSender> logger;

        public EmailSender(IFeatureSettingRepository featureSettingRepository,
            ILogger<EmailSender> logger) 
        {
            this.featureSettingRepository = featureSettingRepository;
            this.logger = logger;
        }
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var port = await featureSettingRepository.GetAsync("Port", null);
            var host = await featureSettingRepository.GetAsync("SmtpHost", null);
            var user = await featureSettingRepository.GetAsync("SmtpUser", null);
            var pass = await featureSettingRepository.GetAsync("SmtpPassword", null);



            if (port == null || port.Value == string.Empty)
            {
                logger.LogError("SMTP port is empty!");
                return;
            }
            if (host == null || host.Value == string.Empty)
            {
                logger.LogError("SMTP host is empty!");
                return;
            }
            if (user == null || user.Value == string.Empty)
            {
                logger.LogError("SMTP credentials user is empty!");
                return;
            }
            if (pass == null || pass.Value == string.Empty)
            {
                logger.LogError("SMTP credentials pass is empty!");
                return;
            }

            int portNum;
            try  {
                portNum = Convert.ToInt32(port);
            } catch (Exception ex)
            {
                logger.LogError($"SMTP port is invalid! ${ex.Message}");
                return;
            }

            SmtpClient client = new SmtpClient
            {
                Port = portNum,
                Host = host.Value,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(user.Value, pass.Value),
            };

            await client.SendMailAsync(user.Value, email, subject, htmlMessage);
        }
    }
}
