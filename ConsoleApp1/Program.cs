using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var character1 = new GameCharacter("Kristy", 100, 5000);
            var character2 = new Warrior("Wren", 55, 100, "daggar");
            var character3 = new Wizard("Rothgar", 10000, 10, 5, 10);


            var gameCharacters = new GameCharacter[5];
            gameCharacters[0] = new Warrior("Wren", 55, 100, "daggar");
            gameCharacters[1] = new Warrior("Bob", 55, 100, "daggar");
            gameCharacters[2] = new Wizard("Rothgar", 10000, 10, 5, 10);
            gameCharacters[3] = new Wizard("Another", 10000, 10, 5, 10);
            gameCharacters[4] = new Wizard("And Another", 10000, 10, 5, 10);

            foreach (var character in gameCharacters)
            {
                character.Play();
                Console.WriteLine();
            }
        }
    }
}
