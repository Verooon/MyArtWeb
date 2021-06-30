﻿using System;
using System.Collections.Generic;
using System.Linq;
 using MyArtWeb.Data;
 using MyArtWeb2.Data;

namespace MyArtWeb.Models
{
    public class UserList : IUserService
    {
        private List<User> users;
        private User user;

        public UserList()
        {
          
        }

        public void AddUser(User user)
        {
            if (ValidateRegistration())
            {
                users.Add(user);
            }
            throw new Exception("Invalid registration");
        }


        public User ValidateUser(string Email, string password)
        {
            User first = users.FirstOrDefault(user => user.Email.Equals(Email));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }

        public Boolean ValidateRegistration()
        {
            char ch1 = '@';
            char ch2 = '.';
            int index1 = user.Email.IndexOf(ch1);
            int index2 = user.Email.IndexOf(ch2);
            if (user.Email.Contains(ch1) && user.Email.Contains(ch2) && index1<index2) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}