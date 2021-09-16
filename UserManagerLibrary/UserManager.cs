using System;

namespace UserManagerLibrary
{
    public class UserManager
    {
        public bool Add(string userId,string phone,string email)
        {
            if(userId.Length<4)
            {
                throw new Exception("Your UserId must be more than 4 character ");
            }
            if(phone.Contains("a"))
            {
                throw new Exception("Your nuber phone must be characters");
            }
            if(!email.Contains("@"))
            {
                throw new Exception("An error in email name address");
            }

            //Statments for save on a DataBase or in a File
            //....
            //....

            return true;
        }
    }
}
