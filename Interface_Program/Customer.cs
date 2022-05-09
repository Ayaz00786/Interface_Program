using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Program
{
    public interface IAuth
    {
        void LoginUser();
        void ForgetPassword();
        void ChangePassword();
    }

    public interface IOperation
    {
        void CreateUser();
        void UpdateUser();
        void DeleteUser();
    }
    public class UserService : IOperation, IAuth
    {
        public void CreateUser() 
        {
            Console.WriteLine("Enter Your Name");
            string name= Console.ReadLine();
            Console.WriteLine("Enter your DOB");
            string dob =Console.ReadLine();
            Console.WriteLine("enter Mobile number");
            string mob= Console.ReadLine();

            Console.WriteLine("Set a username");
            string username = Console.ReadLine();

            Console.WriteLine("Set a password");
            string password= Console.ReadLine();

           
        }
        public void UpdateUser() 
        {
            Console.WriteLine("Enter old username");
            string username = Console.ReadLine();

            Console.WriteLine("Set new username");
            string usernamenew = Console.ReadLine();

            Console.WriteLine("You have changed Username. Your new username is {0}",usernamenew);
        }
        public void DeleteUser() 
        {
            Console.WriteLine("enter your username");
            string username= Console.ReadLine();
            Console.WriteLine("Your Username is deleted");
        }
        public void LoginUser() 
        {
            Console.WriteLine("enter your username");
            string username = Console.ReadLine();

            Console.WriteLine("enter your password");
            string password = Console.ReadLine();
            Console.WriteLine("Login Successfully....");
        }
        public void ChangePassword() 
        {
            Console.WriteLine("Enter old password");
            string username = Console.ReadLine();

            Console.WriteLine("Set new password");
            string usernamenew = Console.ReadLine();
            Console.WriteLine("Password Changes Successfully");
        }
        public void ForgetPassword() 
        {
            Console.WriteLine("Enter your Username:");
            string username= Console.ReadLine();
            
        }


    }
}
