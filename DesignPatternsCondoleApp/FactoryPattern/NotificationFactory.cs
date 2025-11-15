

namespace DesignPatternsConsoleApp.FactoryPattern
{
    public static class NotificationFactory
    {
        public static string Create(string type)
        {
            if (type == "email")
            {
                var email = new EmailNotifier();
                return "Email notification sent!";
            }
            else if (type == "sms")
            {
                var sms = new SmsNotifier();
                return "SMS notification sent!";
            }
            else
            {
                return "Invalid notification type";
            }
        }
    }

}
