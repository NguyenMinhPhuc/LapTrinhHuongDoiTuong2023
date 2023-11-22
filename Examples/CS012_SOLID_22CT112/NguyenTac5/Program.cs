namespace NguyenTac5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notification notification = new Notification();
            Email email = new Email();
            SMS sms = new SMS();
            PostOffice postOffice = new PostOffice();
            //notification.MyMessager = postOffice;
            notification.CallNotification(postOffice);

        }
    }
}