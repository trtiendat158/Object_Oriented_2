using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Book
{
    class Author
    {
        private string Name, Email;
        private char Gender;

        public Author(string Name, string Email, char Gender)
        {
            this.Name = Name;
            this.Email = Email;
            this.Gender = Gender;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetEmail()
        {
            return this.Email;
        }

        public char GetGender()
        {
            return this.Gender;
        }

        public void SetEmail(string Email)
        {
            this.Email = Email;
        }

        public override string ToString()
        {
            return string.Format("Author[name={0},email={1},gender={2}]", this.Name, this.Email, this.Gender);
        }

    }
}