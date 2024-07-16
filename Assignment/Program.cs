using static System.Net.Mime.MediaTypeNames;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 01
            #region 1) What is the primary purpose of an interface in C#?
            //a) To provide a way to implement multiple inheritance

            #endregion
            #region 2) Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private
            #endregion
            #region 3) Can an interface contain fields in C#?
            //b) No
            #endregion
            #region 4) In C#, can an interface inherit from another interface?
            //b) Yes, interfaces can inherit from multiple interfaces
            #endregion
            #region 5) Which keyword is used to implement an interface in a class in C#?
            //d) implements

            #endregion
            #region 6) Can an interface contain static methods in C#?
            //a) Yes
            #endregion
            #region 7) In C#, can an interface have explicit access modifiers for its members?
            //b) No, all members are implicitly public
            #endregion
            #region 8) What is the purpose of an explicit interface implementation in C#?
            //b) To provide a clear separation between interface and class members
            #endregion
            #region 9) In C#, can an interface have a constructor?
            //b) No, interfaces cannot have constructors
            #endregion
            #region 10) How can a C# class implement multiple interfaces?
            //c) By separating interface names with commas
            #endregion

            //part02

            #region Define an interface named IShape with a property Area and a method DisplayShapeInfo.
            //Create two interfaces, ICircle and IRectangle, 
            //that inherit from IShape.Implement these interfaces in classes Circle and Rectangle. 
            //Test your implementation by creating instances of both classes and displaying their shape information.

            //Circle circle = new Circle(15.6);
            //circle.DisplayShapeInfo();
            //Rectangle rectangle = new Rectangle(15.5, 18.5);
            //rectangle.DisplayShapeInfo();
            #endregion
            #region Question 02 

            //BasicAuthenticationService authService = new BasicAuthenticationService("Mohamed", "123456", "User");


            //string username = "Mahmoud";
            //string password = "789523";
            //bool isAuthenticated = authService.AuthenticateUser(username, password);
            //Console.WriteLine($"is this user auhenticated : {isAuthenticated}");

            //string role = "admin";
            //bool isAuthorized = authService.AuthorizeUser(username, role);
            //Console.WriteLine($"user authorized: {isAuthorized}");


            #endregion
            #region Question 03
            //EmailNotificationService EService = new EmailNotificationService();
            //SmsNotificationService SService = new SmsNotificationService();
            //PushNotificationService PService = new PushNotificationService();

            //string recipient = "MariamShindyRoute@gmail.com";
            //string message = "Your FeedBack is very Bad";
            //EService.SendNotification(recipient, message);
            //SService.SendNotification(recipient, message);
            //PService.SendNotification(recipient, message);
            #endregion

        }
}
}
