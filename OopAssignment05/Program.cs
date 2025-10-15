using Assignment05_OOP.Question02;
using Assignment05_OOP.Question03;

namespace Assignment05_OOP.Question01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MainQuestion01
            //Circle c = new Circle(5);
            //Rectangle r = new Rectangle(4, 6);

            //c.DisplayShapeInfo();
            //Console.WriteLine();
            //r.DisplayShapeInfo();
            #endregion

            #region MainQuestion02
            //IAuthenticationService authService = new BasicAuthenticationService();
            //bool isAuthenticated = authService.AuthenticateUser("admin", "1234");
            //bool isAuthorized = authService.AuthorizeUser("admin", "Administrator");
            //Console.WriteLine($"Authenticated: {isAuthenticated}");
            //Console.WriteLine($"Authorized: {isAuthorized}");
            #endregion

            #region MainQuestion03
            //INotificationService emailService = new EmailNotificationService();   // bn5od ref mn el interface m4 obj
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //emailService.SendNotification("nour@example.com", "Welcome to our system!");
            //smsService.SendNotification("+20123456789", "Your OTP code is 4567");
            //pushService.SendNotification("nourDevice", "You have a new message!");
            #endregion
        }
    }
}