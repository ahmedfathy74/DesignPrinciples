using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Vs._Tight_Coupling.Before
{
    public class NotificationService
    {
        private readonly EmailService _emailService;
        private readonly SmsService _smsService;
        public NotificationService(EmailService emailService, SmsService smsService)
        {
            _emailService = emailService;
            _smsService = smsService;   
        }
        public void Notify()
        {
            _emailService.Send();
            _smsService.Send();
        }
    }
}
