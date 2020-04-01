using System;
using System.Text.RegularExpressions;

namespace User_Registration_Problem_CSharp
{
    class Program
    {
        public string validationCheck(string exp, string stringToMatch)
        {
            var match = Regex.Match(stringToMatch, exp, RegexOptions.None);
            if (match.Success)
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
        //method to take first name from user
        public string inputFirstName()
        {
            Console.Write("Enter Name: ");//taking first name from user 
            String firstName = Console.ReadLine();
            return firstName;
        }
        //method to validation of name
        public string validationName(string name)
        {
            var regexExpr = @"^[A-Z]{1}[a-z]{2,}$";
            return this.validationCheck(regexExpr,name);
        }

        //method to take last name from user
        public string inputLastName()
        {
            Console.Write("Enter Name: ");//taking last name from user 
            String lastName = Console.ReadLine();
            return lastName;
        }
        static void Main(string[] args)
        {
            Program user = new Program();
            Console.WriteLine("Welcome to User Registration");
            string firstName = user.inputFirstName();
            Console.WriteLine($"First name {user.validationName(firstName)}");
            string lastName = user.inputLastName();
            Console.WriteLine($"Last name {user.validationName(lastName)}");
        }
    }
}
