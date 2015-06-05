﻿using System;
using YanStore.SharedKernel.Model;

namespace YanStore.Domain.Model.Event
{
    public class UserRegistered : IDomainEvent
    {
        public DateTime DateOccurred { get; private set; }
        public User UserCreated { get; private set; }
        public string EmailTitle { get; private set; }
        public string EmailBody { get; private set; }

        public UserRegistered(User user, DateTime dateOccured)
        {
            this.UserCreated = user;
            this.DateOccurred = DateTime.Now;
            this.EmailTitle = "Seja bem vindo " + user.Username;
            this.EmailBody = "Obrigado por se cadastrar.";
        }

        public UserRegistered(User user) : this(user, DateTime.Now) { }
    }
}
