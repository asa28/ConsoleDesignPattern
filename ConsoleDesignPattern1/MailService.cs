using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDesignPattern1
{
    public class MailService
    {
        public void sendEmail() 
        {
            connect();
            authenticate();
            send();
            disconnect();
        }
        private void connect() 
        {
            
        }
        private void disconnect()
        {

        }
        private void authenticate()
        {

        }
        private void send()
        {

        }
    }
}
