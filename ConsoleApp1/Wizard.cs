using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }

        public Wizard(string name, int strength, int intelligence, int magicalEnergy, int spellNumber):base(name, strength, intelligence, magicalEnergy)
        {
            SpellNumber = spellNumber;       
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Spell Number: {SpellNumber}");
        }
    }
}
