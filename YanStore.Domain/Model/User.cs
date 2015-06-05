﻿using YanStore.Domain.Model.Scopes;

namespace YanStore.Domain.Model
{
    public class User
    {
        protected User() { }
        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.MustResetPassword = false;
            this.IsActive = false;
        }

        public int Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public bool MustResetPassword { get; private set; }
        public bool IsActive { get; private set; }

        public void Authenticate()
        {
            if (!this.IsActive) { }
            //this.Assertion.Add("IsActive", "Usuário inativo");

            if (this.MustResetPassword) { }
                //this.Assertion.Add("MustResetPassword", "Sua senha precisa ser resetada!");
        }

        public void Register()
        {            
            if (this.RegisterUserScopeIsValid())
                return;
        }
    }
}
