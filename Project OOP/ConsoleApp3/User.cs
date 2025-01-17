﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract public class User : IUser
    {

        // SubscriptionType is used in SubscribedUser class instead of Student and Family classes
        // because the following input (adjusted for either students or families) depends on the type of subscription
        protected string SubscriptionType;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public virtual string BorrowBook()
        {

            return $"User {FirstName} {LastName} (Email:{Email}) has borrowed a book\n";
        }

        // Use of generics - the method is able to print out pieces of information
        // of different types (e.g. OIB is a string, ID is a guid)
        public void ReturnListOfInfo<T>(T data)
        {

            Console.WriteLine(data);
        }

        
        
        

    }
}
