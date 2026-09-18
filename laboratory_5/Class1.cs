using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratory_5
{
    internal class Person
    {
        private string name;
        private string surname;
        private int age;
        private string email;
        protected Person()
        {
            name = "";
            surname = "";
            age = 0;
            email = "";
        }
        protected Person(string name,string surname,int age,string email)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.email = email;
        }
        protected Person(Person other)
        {
            this.name = other.name;
            this.surname = other.surname;
            this.age = other.age;
            this.email = other.email;
        }
        protected string Name
        {
            get { return name; }
            set { name = value; }
        }
        protected string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        protected int Age
        {
            get { return age; }
            set { age = value; }
        }
        protected string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
