using System;

namespace Interface_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAuth auth = new UserService();
          
            IOperation operation = new UserService();


            UserService user= new UserService();
           // user.CreateUser();
            user.LoginUser();
            //user.DeleteUser();
            //user.UpdateUser();
          // user.ChangePassword();
          // user.ForgetPassword();


        }
    }
}
