using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignments1
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public interface IUserService
    {
        public User GetUser(int id);
    }
    public class UserService : IUserService
    {
        public User GetUser(int id)
        {
            return new User { Id = id, Name = "John" };
        }
    }
    public class UserController
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        public void DisplayUser(int id)
        {
            var user = _service.GetUser(id);
            Console.WriteLine($"Id: {user.Id}, Name: {user.Name}");
        }
    }   
}
