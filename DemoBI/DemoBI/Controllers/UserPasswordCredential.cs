﻿namespace DemoBI.Controllers
{
    internal class UserPasswordCredential
    {
        private object username;
        private object password;

        public UserPasswordCredential(object username, object password)
        {
            this.username = username;
            this.password = password;
        }
    }
}