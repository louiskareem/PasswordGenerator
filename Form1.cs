using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // When button is click, execute the CreatRandomPassword method.
        private void button1_Click(object sender, EventArgs e)
        {
            // Display password in the textbox
            password_textbox.Text = CreateRandomPassword();
        }

        // Method to create a random number
        public int RandomNumber(int min, int max)
        {
            // Use the Random functin to create a random set of number 
            Random random = new Random();
            return random.Next(min, max);
        }

        // Method to create a random string 
        public string RandomString(int size, bool lowerCase)
        {
            // Use the random and string builder functions 
            StringBuilder builder = new StringBuilder();
            Random random = new Random();

            // char variable
            char ch;

            // Create a random set of number and convert them to characters then add it to the CH variable
            for(int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            // If lowerCase is true then return the variable, if not then return string
            if(lowerCase)
                return builder.ToString().ToLower();
           return builder.ToString();
        }

        // Method to create a random password
        public string RandomPassword(int size = 0)
        {
            // Use the string builder function, then randomize numbers and string 
            // and add them to the called functions and return the string
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));

            return builder.ToString();
            
        }

        // Method to create a random password with a length of 15 characters 
        private static string CreateRandomPassword(int length = 15)
        {
            // Make a string of characters that are allowed to be used
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";

            // Use the random function
            Random random = new Random();

            // Create an character array
            char[] chars = new char[length];

            // Put the valid characters in the characters array, then return the string 
            for(int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }
    }
}
