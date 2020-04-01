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
            Console.Write("Enter First Name: ");//taking first name from user 
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
            Console.Write("Enter Last Name: ");//taking last name from user 
            String lastName = Console.ReadLine();
            return lastName;
        }
        //method to take email address from user
        public string inputEmailAddress()
        {
            Console.Write("Enter Email Address: ");//taking email address from user 
            String emailAddress = Console.ReadLine();
            return emailAddress;
        }
        //method to validate Email Address
        public string validationEmailAddress(string emailAddress)
        {
            var regexExpr = @"^([a-zA-Z]{3,}([.|_|+|-]?[a-zA-Z0-9]+)?[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.]?[a-zA-Z]{2,3})?)$";
            return this.validationCheck(regexExpr, emailAddress);
        }
        static void Main(string[] args)
        {
            Program user = new Program();
            Console.WriteLine("Welcome to User Registration");
            string firstName = user.inputFirstName();
            Console.WriteLine($"First name {user.validationName(firstName)}");
            string lastName = user.inputLastName();
            Console.WriteLine($"Last name {user.validationName(lastName)}");
            string emailAddress = user.inputEmailAddress();
            Console.WriteLine($"Email address {user.validationEmailAddress(emailAddress)}");
        }
    }
}
