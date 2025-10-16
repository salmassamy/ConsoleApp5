namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Question 01: Shapes ===");
            IShape circle = new Circle(5);
            circle.DisplayShapeInfo();

            IShape rectangle = new Rectangle(4, 6);
            rectangle.DisplayShapeInfo();

            Console.WriteLine("\n=== Question 02: Authentication ===");
            IAuthenticationService authService = new BasicAuthenticationService();

            bool isAuthenticated = authService.AuthenticateUser("admin", "1234");
            Console.WriteLine($"Authentication Success: {isAuthenticated}");

            bool isAuthorized = authService.AuthorizeUser("admin", "Administrator");
            Console.WriteLine($"Authorization Success: {isAuthorized}");

            Console.WriteLine("\n=== Question 03: Notifications ===");
            INotificationService emailService = new EmailNotificationService();
            emailService.SendNotification("user@example.com", "Welcome to our system!");

            INotificationService smsService = new SmsNotificationService();
            smsService.SendNotification("+20123456789", "Your code is 9876");

            INotificationService pushService = new PushNotificationService();
            pushService.SendNotification("User123", "You have a new alert!");
        }
    }
    }