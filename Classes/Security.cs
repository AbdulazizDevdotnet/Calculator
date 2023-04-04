using System;

namespace CALCULATOR.Classes
{

    class Security
    {
        public void CheckPassword()
        {
            string password = "";
            Console.Write("Dasturdan foydalanish uchun iltimos parolni kiriting: ");
            password = Console.ReadLine();
            if(password != "Abdulaziz20")
            {
                do
                {
                    Console.Write("Xato parol\nParolni kiriting:");
                    password = Console.ReadLine();
                }while(password != "Abdulaziz20");
            }
        }
    }
}