using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class EmailNotificationService : INotificationService
    {
        public void SendNotification(string Recipient, string Message)
        {
            Console.WriteLine($"Sending an email to {Recipient}: {Message}");
        }
    }
}
