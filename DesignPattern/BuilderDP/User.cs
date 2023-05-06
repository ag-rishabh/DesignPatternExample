using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderDP
{
    public class User
    {
        private string _name;
        private string _email;
        private int _age;
        private string _address;

        private User() { }

        public string Name { get { return _name; } }
        public string Email { get { return _email; } }
        public int Age { get { return _age; } }
        public string Address { get { return _address; } }


        public class UserBuilder
        {
            private readonly User user;

            public UserBuilder()
            {
                user = new User();
            }

            public UserBuilder SetName(string name)
            {
                user._name = name;
                return this;
            }

            public UserBuilder SetEmail(string email)
            {
                user._email = email;
                return this;
            }

            public UserBuilder SetAge(int age) 
            { 
                user._age = age; 
                return this; 
            }

            public UserBuilder SetAddress(string address)
            {
                user._address = address;
                return this;
            }

            public User Build()
            {
                Console.WriteLine("User object is created");
                return user;
            }
        }

    }
}
