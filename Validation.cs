using System;
using System.Collections.Generic;
using System.Text;

namespace User_Registration_Problem_CSharp
{
    interface Validation
    {
        /// <summary>
        /// Method to match input string with input regular expression
        /// </summary>
        /// <param name="expression">regular expression</param>
        /// <param name="stringToMatch">string to match with regular expression</param>
        /// <returns></returns>
        string validationCheck(string expression, string stringToMatch);

        /// <summary>
        /// Method to validation First name
        /// </summary>
        /// <param name="firstName"> The firstname string to be validation with regular expression </param>
        /// <returns></returns>
        string validationFirstName(string firstName);
        /// <summary>
        /// Method to validation Last name
        /// </summary>
        /// <param name="lastName">The lastname string to be validation with regular expression</param>
        /// <returns></returns>
        string validationLastName(string lastName);
        /// <summary>
        /// Method to validation Email Address
        /// </summary>
        /// <param name="emailAddress">The email address string to be validation with regular expression</param>
        /// <returns></returns>
        string validationEmailAddress(string emailAddress);
        /// <summary>
        /// Method to validation Mobile Number
        /// </summary>
        /// <param name="MobileNumber">The Mobile number string to be validation with regular expression</param>
        /// <returns></returns>
        string validationMobileNumber(string MobileNumber);
        /// <summary>
        /// Method to validation Password
        /// </summary>
        /// <param name="password">The password string to be validation with regular expression</param>
        /// <returns></returns>
        string validationPassword(string password);
    }
}
