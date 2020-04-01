using System;
using System.Text.RegularExpressions;

namespace User_Registration_Problem_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program user = new Program();
            Console.WriteLine("Welcome to User Registration");
            string firstName=user.inputFirstName();
            user.validationFirstName(firstName);
        }
        //method to take first name from user
        public string inputFirstName()
        {
            Console.Write("Enter Name: ");//taking first name from user 
            String firstName = Console.ReadLine();
            return firstName;
        }
        //method to validation of first name
        public void validationFirstName(string firstName)
        {
            var regexExpr = @"^[A-Z]{1}[a-z]{2,}$";
            var match = Regex.Match(firstName, regexExpr,RegexOptions.None);
            if(match.Success)
            {
                Console.WriteLine("Valid firstname");
            }
            else
            {
                Console.WriteLine("Invalid firstname");
            }
        }
    }
}
