using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace HelpLone
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>();

            characters.Add(new Babarian());
            characters.Add(new Knight());
            characters.Add(new Witch());
            characters.Add(new Wizard());

            foreach (Character character in characters)
            {
                character.Fight();

                if (character is IThrowingSpells throwing)
                {
                    throwing.ThrowFrostNova();
                    throwing.ThrowMagicMisile();
                }

                if (character is ICommonMagic commonMagic)
                {
                    commonMagic.Teleport(10,30);
                }

                if (character is IShield shield)
                {
                    shield.RaiseShield();
                    shield.ShieldGlare();
                }

                if (character is IHeavyAttack heavyAttack)
                {
                    heavyAttack.Bash();
                    heavyAttack.Cleave();
                }

                if (character is ILightAttack lightAttack)
                {
                    lightAttack.Slash();
                }

                character.Heal();

                character.Die();

                Console.WriteLine("________");
            }

            Console.ReadLine();
        }

    }
}
