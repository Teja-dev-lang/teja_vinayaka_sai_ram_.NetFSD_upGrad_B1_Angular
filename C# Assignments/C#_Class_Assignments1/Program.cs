namespace C__Class_Assignments1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUserService service = new UserService();
            UserController controller = new UserController(service);

            controller.DisplayUser(1);
        }
    }
}
