using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IUser
    {
        string Name { get; }
        string Address { get; }
        int Age { get; }

    }
    public class User : IUser
    {
        private string name;
        private string address;
        private int age;

        public string Name => name;

        public string Address => address;

        public int Age => age;

        public class UserBuilder
        {
            private readonly User user;

            public UserBuilder()
            {
                user = new User();
            }

            public UserBuilder WithAge(int age)
            {
                user.age = age;
                return this;
            }

            public UserBuilder WithName(string name)
            {
                user.name = name;
                return this;
            }

            public UserBuilder WithAdress(string address)
            {
                user.address = address;
                return this;
            }

            public User Build() => user;

        }
    }
}
