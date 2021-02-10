using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }

        public MagicUsingCharacter(string name, int strength, int intelligence, int magicalEnergy) : base(name, strength, intelligence)
        {
            MagicalEnergy = magicalEnergy;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Magical Energy: {MagicalEnergy}");
        }
    }
}
