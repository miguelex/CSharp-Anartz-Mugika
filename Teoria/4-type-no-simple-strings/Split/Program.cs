using System;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterVideoGames = "Mario/Luigi/Sack Boy/Lara Croft/SolidSnake/Sonic";

            string [] characterList = characterVideoGames.Split("/");

            string message = "¡Hola Anartz! ¿Que tal estas? (Espero que todo bien.)";
            char [] separatorList = {'¡','¿','('};
            string [] messageList = message.Split(separatorList);
        }
    }
}
