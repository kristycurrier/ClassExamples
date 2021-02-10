using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public GameCharacter(string name, int strength, int intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }

        public GameCharacter( string name)
        {
            Name = name;
        }

        public GameCharacter()
        {

        }

        public virtual void Play() 
        {
            Console.WriteLine($"The character is {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
        }
    }
}
