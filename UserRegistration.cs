using System;
using System.Text.RegularExpressions;

namespace User_Registration_Problem_CSharp
{
    class UserRegistration : Validation
        
    {
        /// <summary>
        /// Interface Method to checking for validation all user details.
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="stringToMatch"></param>
        /// <returns></returns>
        public string validationCheck(string expression, string stringToMatch)
        {
            Match valid = Regex.Match(stringToMatch, expression, RegexOptions.None);
            if (valid.Success)
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
        /// <summary>
        /// Method to take first name from user
        /// </summary>
        /// <returns></returns>
        public string inputFirstName()
        {
                Console.Write("Enter First Name: ");//taking first name from user 
                String firstName = Console.ReadLine();
                return firstName;
        }
        /// <summary>
        /// Interface method to validation of firstname
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public string validationFirstName(string firstName)
        {
            string regexExpression = "^[A-Z]{1}[a-z]{2,}$";
            return this.validationCheck(regexExpression,firstName);
        }
        /// <summary>
        /// method to take last name from user
        /// </summary>
        /// <returns></returns>
        public string inputLastName()
        {
            Console.Write("Enter Last Name: ");
            String lastName = Console.ReadLine();
            return lastName;
        }
        /// <summary>
        ///  Interface method to validation of lastname
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public string validationLastName(string lastName)
        {
            string regexExpression = "^[A-Z]{1}[a-z]{2,}$";
            return this.validationCheck(regexExpression, lastName);
        }
        /// <summary>
        /// method to take email address from user
        /// </summary>
        /// <returns></returns>
        public string inputEmailAddress()
        {
                Console.Write("Enter Email Address: ");//taking email address from user 
                String emailAddress = Console.ReadLine();
                return emailAddress;
        }
        /// <summary>
        /// Inteface method to validate Email Address
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <returns></returns>
        public string validationEmailAddress(string emailAddress)
        {
            string regexExpression = "^([a-zA-Z]{3,}([.|_|+|-]?[a-zA-Z0-9]+)?[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.]?[a-zA-Z]{2,3})?)$";
            return this.validationCheck(regexExpression, emailAddress);
        }
        /// <summary>
        /// method to take mobile number from user
        /// </summary>
        /// <returns></returns>
        public string inputMobileNumber()
        {
            Console.Write("Enter Mobile Number: ");//taking mobile number from user 
            String mobileNumber = Console.ReadLine();
            return mobileNumber;
        }
        /// <summary>
        /// Interface method to validate Mobile number
        /// </summary>
        /// <param name="mobileNumber"></param>
        /// <returns></returns>
        public string validationMobileNumber(string mobileNumber)
        {
            string regexExpression = "^([0-9]{2}[ ]{1}[0-9]{10})$";
            return this.validationCheck(regexExpression, mobileNumber);
        }
        /// <summary>
        /// method to take password from user
        /// </summary>
        /// <returns></returns>
        public string inputPassword()
        {
            Console.Write("Enter password: ");//taking password from user 
            string password = Console.ReadLine();
            return password;
        }
        /// <summary>
        /// method to validate password minimum 8 charachter atleast one number at least one special character validation
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>

        public string validationPassword(string password)
        {
            string regexExpression = "^(?=.*[A-Z])(?=.*[0-9])(?=[^@#$%^&+=]*[@#$%^&+=][^@#$%^&+=]*$)(.{8,})$";
            return this.validationCheck(regexExpression, password);
        }
        static void Main(string[] args)
        {
            UserRegistration user = new UserRegistration();
            Console.WriteLine("Welcome to User Registration");
            string firstName = user.inputFirstName();
            Console.WriteLine($"First name {user.validationFirstName(firstName)}");
            string lastName = user.inputFirstName();
            Console.WriteLine($"Last name {user.validationLastName(lastName)}");
            string emailAddress = user.inputEmailAddress();
            Console.WriteLine($"Email address {user.validationEmailAddress(emailAddress)}");
            string mobileNumber = user.inputMobileNumber();
            Console.WriteLine($"Mobile Number {user.validationMobileNumber(mobileNumber)}");
            string password = user.inputPassword();
            Console.WriteLine($"Paasword {user.validationPassword(password)}");
        }
    }
}
