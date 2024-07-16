using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class PushNotificationService : INotificationService

    {
        public void SendNotification(string Recipient, string Message)
        {
            Console.WriteLine($"Sending a push notification to {Recipient}: {Message}");
        }
    }
}
