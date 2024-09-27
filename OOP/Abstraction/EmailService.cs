﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    class EmailService
    {
        public void sendEmail()
        {
            Connect();
            Authenticate();
            Console.WriteLine("Sending email...");
            Disconnect();
        }

        // ALL THE BELOW METHODS ARE PRIVATE -- THEY ARE NOT EXPOSED TO OTHER CLASSES. OTHER CLASSES JUST WANT TO SEND EMAILS, NO NEED FOR THEM TO SEE ALL THE COMPLEX DETAILS OF CONNECTING TO MAIL SERVER, AUTHENTICATING, DISCONNECTING.

        private void Connect()
        {
            Console.WriteLine("Connecting to email server...");
        }

        private void Authenticate()
        {
            Console.WriteLine("Authenticating...");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnecting from email server...");
        }
    }
}