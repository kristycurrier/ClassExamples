using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }

        public Warrior(string name, int strength, int intelligence, string weaponType) : base(name, strength, intelligence)
        {
            WeaponType = weaponType;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Weapon: {WeaponType}");
        }
    }
}
